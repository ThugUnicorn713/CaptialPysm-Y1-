using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardDoor : MonoBehaviour
{
    public GameObject player;
    public GameObject Reward;

    public void RewardPlayer()
    {
        Reward.SetActive(true);
    }
}
