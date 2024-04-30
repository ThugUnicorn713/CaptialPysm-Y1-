using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickMeUp : MonoBehaviour
{
    Camera cam;
    [SerializeField] GameObject Piggy;

    // Start is called before the first frame update
    void Start()
    {
        cam = this.GetComponentInChildren<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        PickUpPiggy();
    }

    private void PickUpPiggy()
    {
        RaycastHit hit;
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F PRESSED");
            float distance = 2f;

            //Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            Ray ray = new Ray(cam.transform.position, cam.transform.forward);

            if (Physics.Raycast(ray, out hit, distance)) // Cast a ray forwards from the player reaching the set distance. output what you find to "hit" 
            {
                Debug.Log("HIT: " + hit.transform.name);
                if ((hit.transform.name == "Piggy"))
                {
                    Piggy.SetActive(true);
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
