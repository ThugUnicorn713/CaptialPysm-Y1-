using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPool : MonoBehaviour
{
   
    [SerializeField] float hitPoints = 100f;
    [SerializeField] float rawDamage = 10f;
    [SerializeField] float benniDamage = 15f;

   public void Hit(float rawDamage)
   {
            hitPoints -= rawDamage;

            Debug.Log($"NOOOO: {hitPoints}");

            if (hitPoints <= 0)
            {
                Debug.Log("I DIED!!! GAME OVER");
                Destroy(gameObject);
            
            }
   }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Hit(rawDamage);
        }
        else if (collision.gameObject.CompareTag("Benni"))
        {
            Hit(benniDamage);
        }
        
    }
}
