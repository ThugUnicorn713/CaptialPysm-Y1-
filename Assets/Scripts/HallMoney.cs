using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallMoney : MonoBehaviour
{
    private static HallMoney instance;
    [SerializeField] GameObject[] hallRewards;
    private void Start()
    {
        instance = this; //storing the instance statically (object as far as classes go)
    }

    public static HallMoney GetInstance() //getter
    {

        return instance;
    }

    public GameObject GetHallReward()
    {
        HallMoney hallMoney = GetInstance();

        if (hallMoney != null)
        {
            GameObject[] hallRewards = hallMoney.hallRewards;
            if (hallRewards.Length > 0)
            {
                int spawnReward = Random.Range(0, hallRewards.Length);
                return hallRewards[spawnReward];
            }
            else
            {
                Debug.LogWarning("No rooms found in the HallMoney.");
            }
        }
        else
        {
            Debug.LogWarning("HallMoney instance is null.");
        }

        return null;
    } 

}
