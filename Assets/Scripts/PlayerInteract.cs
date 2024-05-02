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

                    var interact = hit.transform.GetComponent<Interact>();
                      if (interact != null)
                      {
                        Debug.Log(hit.transform.name + " has Interact, sending to room");
                        interact.SendToRoom();
                      }
                    var interactHall = hit.transform.GetComponent<InteractHall>();
                        if (interactHall != null)
                        {
                         Debug.Log(hit.transform.name + " has InteractHall, sending to hall");
                         interactHall.SendToHall();
                        }
                    var getBossRoom = hit.transform.GetComponent<GetBossRoom>();
                     if (getBossRoom != null)
                     {
                        Debug.Log(hit.transform.name + " has GetBossRoom, sending to Benni");
                        getBossRoom.SendToBoss();
                     }
                   
                }
            }
        }
    }

}
