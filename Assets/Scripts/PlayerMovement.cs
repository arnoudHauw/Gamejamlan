using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    CharacterController controller; 

    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    public float boostSpeed = 95.0f;

    void start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movementSpeed = movementSpeed + boostSpeed;
        }
        
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            movementSpeed = movementSpeed - boostSpeed;
        }
    }
}