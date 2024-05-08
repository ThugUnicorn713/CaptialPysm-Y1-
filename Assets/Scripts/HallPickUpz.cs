using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class HallPickUpz : MonoBehaviour
{
    public int amount = 5000;
    public GameObject piggy;
    public void GiveHallPick()
    {
        //GameObject.Find("Piggy").GetComponent<shoot>().moneyPool += amount;
        piggy.GetComponent<shoot>().moneyPool += amount;
        GameManager.instance.UpdateBankUI();
        
        Debug.Log("You now have" +  amount);
        Destroy(gameObject);

    }
    

}
