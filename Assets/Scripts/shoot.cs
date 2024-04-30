using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;
    public float launchVelocity = 800f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject billbullet = Instantiate(bullet, transform.position,transform.rotation);

            billbullet.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(launchVelocity, 0, 0));
        }
    }
}
