using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class PlayerInteract : MonoBehaviour
{
    Camera cam;
   

    private void Start()
    {
        cam = this.GetComponentInChildren<Camera>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        { 
            float distance = 5f;
            RaycastHit hit; 
            
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, distance)) // Cast a ray forwards from the player reaching the set distance. output what you find to "hit"
            {
                if (hit.transform.name == "frame") // if the "hit" gameobject is named "frame"
                {
                    Debug.Log("You have used the door");

                    if (hit.transform.TryGetComponent<Interact>(out Interact interact))
                    {
                        Debug.Log(hit.transform.name + " has Interact, sending to room");
                        interact.SendToRoom();

                    }
                    else if (hit.transform.TryGetComponent<InteractHall>(out InteractHall interactHall))
                    {
                        Debug.Log(hit.transform.name + " has InteractHall, sending to hall");
                        interactHall.SendToHall();

                    }
                    else if (hit.transform.TryGetComponent<GetBossRoom>(out GetBossRoom getBossRoom))
                    {
                        Debug.Log(hit.transform.name + " has GetBossRoom, sending to Benni");
                        getBossRoom.SendToBoss();

                    }
                    else if (hit.transform.TryGetComponent<DeathDoor>(out DeathDoor deathDoor))
                    {
                        Debug.Log(hit.transform.name + " has DeathDoor, kill this mf");
                        deathDoor.KillPlayer();

                    }
                    else if (hit.transform.TryGetComponent<PickUpz>(out PickUpz pickUpz))
                    {
                        Debug.Log(hit.transform.name + " has Money, MAKE IT RAIN!!!");
                        pickUpz.Give();

                    }

                }
                
            }
            
        }
    }

}
