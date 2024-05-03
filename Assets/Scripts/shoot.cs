using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;
    public float launchVelocity = 800f;
    public int moneyPool = 5000000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && moneyPool > 0)
        {
            GameObject billbullet = Instantiate(bullet, transform.position,transform.rotation);

            billbullet.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(launchVelocity, 0, 0));

            moneyPool--;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    
}
