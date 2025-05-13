using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("References")]
    private CharacterController controller;
    [SerializeField] private Transform camera;

    [Header("Movement Settings")]
    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private float turningSpeed = 2f;
    [SerializeField] private float gravity = 9.81f;

    [SerializeField] private float waittime= 0.2f;

    private float verticalVelocity;

    [Header("Input")]
    private float moveInput;
    private float turnInput;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        InputManagement();
        Movement();
    }

    private void InputManagement()
    {
        turnInput = Input.GetAxis("Horizontal");
        moveInput = Input.GetAxis("Vertical");

    }

    private void Movement()
    {
        GroundMovement();
        Turn();
    }
    private void GroundMovement()
    {
        Vector3 move = new Vector3(turnInput,0,moveInput);
        move = transform.TransformDirection(move);
        move.y=VerticalForceCalculation();

        move*= walkSpeed;
        if (waittime >= Time.deltaTime)
        {
            controller.Move(move * waittime);

        }
        else
        {    
            controller.Move(move * Time.deltaTime);
        }
        
    }
    private void Turn()
    {
        if ( Mathf.Abs(turnInput)> 0 || Mathf.Abs(moveInput)>0)
        {
            Vector3 currentLookDirection = camera.forward;
            currentLookDirection.y=0;

            Quaternion targetRotation = Quaternion.LookRotation(currentLookDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation,targetRotation,Time.deltaTime*turningSpeed);
        }
    }
    private float VerticalForceCalculation()
    {
        if (controller.isGrounded)
        {
            verticalVelocity= -1f;
        }
        else
        {
            verticalVelocity -=gravity * Time.deltaTime;
        }
        return verticalVelocity;
    }
}
