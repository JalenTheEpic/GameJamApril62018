using UnityEngine;

public class Door : MonoBehaviour
{
    // Smothly open a door
    private float smooth = 2.0f;

    public float DoorOpenAngle = 90.0f;
    private float DoorCloseAngle = 0.0f;
    public bool open;
    public bool enter;
    public bool requires_item;
    public Items required_item;
    private PlayerInventory playerInventory;
    public bool done;

    //0 door open
    //1 door close
    //2 locked door attempt
    public AudioClip[] audioClips;

    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = null;
        done = true;
    }

    //Main function
    private void Update()
    {
        if (open)
        {
            var target = Quaternion.Euler(0, DoorOpenAngle, 0);
            // Dampen towards the target rotation
            transform.localRotation = Quaternion.Slerp(transform.localRotation, target, Time.deltaTime * smooth);
        }

        if (!open)
        {
            var target1 = Quaternion.Euler(0, DoorCloseAngle, 0);
            // Dampen towards the target rotation
            transform.localRotation = Quaternion.Slerp(transform.localRotation, target1, Time.deltaTime * smooth * 2);
            if (transform.localRotation.eulerAngles.y <=  4 && transform.localRotation.eulerAngles.y >=  - 4 && !done)
            {
                done = true;
                audioSource.PlayOneShot(audioClips[1]);
            }
        }

        if (enter == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (requires_item)
                {
                    if (playerInventory.mItems[required_item])
                    {
                        done = false;
                        open = !open;
                        if(open)
                            audioSource.PlayOneShot(audioClips[0]);
                    }
                    else
                    {
                        audioSource.PlayOneShot(audioClips[2]);
                    }
                }
                else
                {
                    open = !open;
                    
                    if (open)
                    {
                        audioSource.PlayOneShot(audioClips[0]);
                    }
                    else
                    {
                        done = false;
                    }
                }
            }
        }
    }

    //Activate the Main function when player is near the door
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerInventory = other.GetComponent<PlayerInventory>();
            enter = true;
        }
    }

    //Deactivate the Main function when player is go away from door
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enter = false;
        }
    }
}