using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractHall : MonoBehaviour
{
    Camera cam;
    public GameObject playerObject;
    public GameObject hallReward;
    public Transform spawnPoint;

    private void Start()
    {
        cam = playerObject.GetComponentInChildren<Camera>();
    }

    public void SendToHall()
    {
        RoomGenerator.GetInstance().GetHall();

        Transform tform = RoomGenerator.GetInstance().FindPlayerHallPosition();
        Debug.Log("Transform passed: | " + tform);
        if (transform != null)
        {
            CharacterController characterController = playerObject.GetComponent<CharacterController>();
            characterController.enabled = false;

            GameObject hallReward = HallMoney.GetInstance().GetHallReward();

            Instantiate(hallReward, spawnPoint.position, Quaternion.identity);

            playerObject.transform.SetPositionAndRotation(tform.position, tform.rotation);
            characterController.enabled = true; 
        }
        else
        {
            Debug.LogWarning("No empty GameObject found inside the spawned object.");
        }
    }

}