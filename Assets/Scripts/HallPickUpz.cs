using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallPickUpz : MonoBehaviour
{
    public int amount = 5000;
    public void GiveHallPick()
    { 
        GameObject.Find("Piggy").GetComponent<shoot>().moneyPool += amount;
        Debug.Log("You now have" +  amount);
        Destroy(gameObject);

    }
    

}
