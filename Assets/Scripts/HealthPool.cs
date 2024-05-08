using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HealthPool : MonoBehaviour
{
   
     public float hitPoints = 100f;
    [SerializeField] float damage = 10f;
    [SerializeField] float benniDamage = 15f;
    [SerializeField] string playDeath = "DeathScene";

     public void Hit(float damage)
   {
            hitPoints -= damage;

            Debug.Log($"NOOOO: {hitPoints}");

            if (hitPoints <= 0)
            {
                Debug.Log("I DIED!!! GAME OVER");
                SceneManager.LoadScene(playDeath);
                Destroy(gameObject);
            
            }

            GameManager.instance.UpdateHealthUI();
   }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Hit(damage);
        }
        else if (collision.gameObject.CompareTag("Benni"))
        {
            Hit(benniDamage);
        }
        
    }
}
