using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour
{

    CharacterController characterController;
    public Transform playerContainer, MainCamera;
    [SerializeField] Collider groundCheck;

    [SerializeField] public float speed = 3.0f;
    public float jumpSpeed = 2f;
    public float mouseSensitivity = 1f;
    public float gravity = 20.0f;
    public float lookUpClamp = -30f;
    public float lookDownClamp = 60f;
    public float horizionalMove = 0f;

    private Vector3 moveDirection = Vector3.zero;
    float rotateX, rotateY;
    private bool jumped;
    private bool grounded;


    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        characterController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        Locomotion();
        RotateAndLook();
    }

    

    void Locomotion()
    {
        if (characterController.isGrounded) // When grounded, set y-axis to zero (to ignore it)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            
        
        }

        //Debug.Log("Grounded: " + characterController.isGrounded);
        //Debug.Log("Grounded: " + grounded);

        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            moveDirection.y = jumpSpeed;
            
        }

        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);

    }

    void RotateAndLook()
    {
        rotateX = Input.GetAxis("Mouse X") * mouseSensitivity;
        rotateY -= Input.GetAxis("Mouse Y") * mouseSensitivity;

        rotateY = Mathf.Clamp(rotateY, lookUpClamp, lookDownClamp);

        transform.Rotate(0f, rotateX, 0f);

        MainCamera.transform.localRotation = Quaternion.Euler(rotateY, 0f, 0f);
       
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("TAG " + other.gameObject.tag);
        if (other.gameObject.tag == "JumpableSurface")
        {
            grounded = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "JumpableSurface")
        {
            grounded = false;
        }
    }

}