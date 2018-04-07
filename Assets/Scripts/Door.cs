using UnityEngine;

public class Door : MonoBehaviour
{
    // Smothly open a door
    private float smooth = 2.0f;

    private float DoorOpenAngle = 90.0f;
    private float DoorCloseAngle = 0.0f;
    public bool open;
    public bool enter;

    //Main function
    private void Update()
    {

        if (open == true)
        {
            var target = Quaternion.Euler(0, DoorOpenAngle, 0);
            // Dampen towards the target rotation
            transform.localRotation = Quaternion.Slerp(transform.localRotation, target, Time.deltaTime * smooth);
        }

        if (open == false)
        {
            var target1 = Quaternion.Euler(0, DoorCloseAngle, 0);
            // Dampen towards the target rotation
            transform.localRotation = Quaternion.Slerp(transform.localRotation, target1, Time.deltaTime * smooth);
        }

        if (enter == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                open = !open;
            }
        }
    }

    //Activate the Main function when player is near the door
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
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