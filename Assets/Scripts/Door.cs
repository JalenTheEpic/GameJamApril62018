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
    private bool done;

    //0 door open
    //1 door close
    //2 locked door attempt
    public AudioClip[] audioClips;

    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
            if (transform.localRotation.eulerAngles.y <= DoorCloseAngle + 7 && transform.localRotation.eulerAngles.y >= DoorCloseAngle - 7 && !done)
            {
                done = true;
                audioSource.clip = audioClips[1];
                audioSource.Play();
            }
        }

        if (enter == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!open && requires_item)
                {
                    if (playerInventory.mItems[required_item])
                    {
                        audioSource.clip = audioClips[0];
                        audioSource.Play();
                        open = true;
                        done = false;
                    }
                    else
                    {
                        audioSource.clip = audioClips[2];
                        audioSource.Play();
                    }
                }
                else
                {
                    open = !open;
                    done = false;
                    if (open)
                    {
                        audioSource.clip = audioClips[0];
                        audioSource.Play();
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