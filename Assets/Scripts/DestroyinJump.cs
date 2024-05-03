using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyinJump : MonoBehaviour
{
    private void OnTriggerEnter(Collider collison)
    {
            if (collison.gameObject.CompareTag("lava"))
            {
                Debug.Log("OOPS LAVA, GAME OVER");
                gameObject.SetActive(false);
            } 
    }
}
