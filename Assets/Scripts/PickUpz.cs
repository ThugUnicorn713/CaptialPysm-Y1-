using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpz : MonoBehaviour
{
    public int amount = 5000;
    public void Give()
    { 
        GameObject.Find("Piggy").GetComponent<shoot>().moneyPool += amount;
        GameManager.instance.UpdateBankUI();
        
        Destroy(gameObject);

    }
    

}
