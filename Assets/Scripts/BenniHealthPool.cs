using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenniHealthPool : MonoBehaviour
{

    [SerializeField] float hitPoints = 100f;
    [SerializeField] float rawDamage = 10f;
    
    void Hit(float rawDamage)
    {
        hitPoints -= rawDamage;

        Debug.Log($"OUCH: {hitPoints}");

        if (hitPoints <= 0)
        {
            Debug.Log("YOU WON, GAME OVER!");
            Dead();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.CompareTag("Bullet"))
        {
            Hit(rawDamage);
        }

    }

    void Dead()
    {
        Destroy(gameObject);
    }
}
