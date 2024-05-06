using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthPool : MonoBehaviour
{

    [SerializeField] float hitPoints = 50f;
    [SerializeField] float rawDamage = 10f;
    public GameObject money;
    void Hit(float rawDamage)
    {
        hitPoints -= rawDamage;

        Debug.Log($"OUCH: {hitPoints}");

        if (hitPoints <= 0)
        {
            Debug.Log("Evil Terminated!!!");
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
        gameObject.SetActive(false);

        int val = Random.Range(0, 2);

        if (val > 0) 
        {
            GameObject pickup = Instantiate(money, transform.position, Quaternion.identity);
            pickup.GetComponent<PickUpz>().amount = 5000;
            
        }

        Destroy(gameObject);
    }
}
