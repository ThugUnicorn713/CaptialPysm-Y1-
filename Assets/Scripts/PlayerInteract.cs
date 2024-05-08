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
                else if (hit.transform.TryGetComponent<RewardDoor>(out RewardDoor rewardDoor))
                {
                    Debug.Log(hit.transform.name + " has RewardDoor, Good Job YOU RICH!!!");
                    rewardDoor.RewardPlayer();

                }
                else if (hit.transform.TryGetComponent<PickUpz>(out PickUpz pickupz))
                {
                    Debug.Log(hit.transform.name + " has Money, make it RAIN!!!");
                    pickupz.Give();
                }
                else if (hit.transform.TryGetComponent<HallPickUpz>(out HallPickUpz hallpickupz))
                {
                    Debug.Log(hit.transform.name + " has a hall pick up!");
                    hallpickupz.GiveHallPick();
                }
                else if (hit.transform.TryGetComponent<Pin>(out Pin pin))
                {
                    Debug.Log(hit.transform.name + " has a pin #!");
                    pin.OpenPin();
                }
                else if (hit.transform.TryGetComponent<ATM>(out ATM atm))
                {
                    Debug.Log(hit.transform.name + " has A way for you to enter PIN!");
                    atm.OpenATM();
                }
                else if (hit.transform.TryGetComponent<PTG>(out PTG ptg))
                {
                    Debug.Log(hit.transform.name + " has an ultimite test...");
                    ptg.OpenPanel();
                }
                else if (hit.transform.TryGetComponent<Win>(out Win win))
                {
                    Debug.Log(hit.transform.name + "YOUR WIN SCORE");
                    win.GetWinPanel();
                }
            }
        }
    }

}
