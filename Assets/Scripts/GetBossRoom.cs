using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBossRoom : MonoBehaviour
{
    Camera cam;
    public GameObject playerObject;

    private void Start()
    {
            cam = playerObject.GetComponentInChildren<Camera>();
    }
  
  
    public void SendToBoss()
    {
        RoomGenerator.GetInstance().GetBossRoom();

        Transform tform = RoomGenerator.GetInstance().FindPlayerBossPosition();
        if (tform != null)
        {
            CharacterController characterController = playerObject.GetComponent<CharacterController>();
            characterController.enabled = false;
            playerObject.transform.SetPositionAndRotation(tform.position, tform.rotation);
            characterController.enabled = true;
        }
        else
        {
            Debug.LogWarning("No empty GameObject found inside the spawned object.");
        }
    }

   

}
