using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathDoor : MonoBehaviour
{
    public GameObject player;

    public void KillPlayer()
    {
        player.GetComponent<HealthPool>().Hit(1000);
    }


}
