using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyinJump : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (CompareTag("Player"))
        {
            if (gameObject.CompareTag("lava"))
            {
                Debug.Log("OOPS LAVA, GAME OVER");
                Destroy(gameObject);
            }
        }
    }
}
