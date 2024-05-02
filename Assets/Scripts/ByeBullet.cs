using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByeBullet : MonoBehaviour
{
    public GameObject floor;
    

   private void OnCollisionEnter(Collision collision)
   {
        if (collision.gameObject == floor)
        {
            Debug.Log("Hit Floor");
            gameObject.SetActive(false);

        }
   }
}
