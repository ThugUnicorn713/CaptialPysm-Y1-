using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyinJump : MonoBehaviour
{
    [SerializeField] string playDeath = "DeathScene";
    private void OnTriggerEnter(Collider collison)
    {
            if (collison.gameObject.CompareTag("lava"))
            {
                Debug.Log("OOPS LAVA, GAME OVER");
                SceneManager.LoadScene(playDeath);
                gameObject.SetActive(false);
            } 
    }
}
