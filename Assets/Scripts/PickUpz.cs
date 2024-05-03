using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpz : MonoBehaviour
{
    public GameObject piggyObject;
    public int amount = 5000;
    
    public void Give()
    { 
        piggyObject.GetComponent<shoot>().moneyPool += amount;  
    }
    //update this for prefab, look at pic

}
