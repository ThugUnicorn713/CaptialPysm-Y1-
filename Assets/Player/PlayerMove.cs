using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour
{

    CharacterController characterController;
    Transform playerContainer, cameraContainer;

    [SerializeField] public float speed = 3.0f;
    public float jumpSpeed = 2f;
    public float mouseSensitivity = 2f;
    public float gravity = 50.0f;
    public float lookUpClamp = -30f;
    public float lookDownClamp = 60f;

    private Vector3 moveDirection = Vector3.zero;
    float rotateX, rotateY;


    void Start()
    {
        Cursor.visible = false;
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveDirection.y = jumpSpeed;
        }
        if (Input.GetKey(KeyCode.C))
        {
            characterController.height = 0.65f;
            characterController.center = new Vector3(0f, 0.5f, 0f);
        }
        else //if (Input.GetKeyUp(KeyCode.C))
        {
            characterController.height = 2f;
            characterController.center = new Vector3(0f, 1f, 0f);
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

        //cameraContainer.transform.localRotation = Quaternion.Euler(rotateY, 0f, 0f);
    }
}