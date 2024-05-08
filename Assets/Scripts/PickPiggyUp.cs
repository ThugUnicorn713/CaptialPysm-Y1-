using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickPiggyUp : MonoBehaviour
{
    Camera cam;
    [SerializeField] GameObject Piggy;
    public GameObject enemy;
    public Transform[] spawnPoints;
    


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
            float distance = 3f;

            //Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            Ray ray = new Ray(cam.transform.position, cam.transform.forward);

            if (Physics.Raycast(ray, out hit, distance)) // Cast a ray forwards from the player reaching the set distance. output what you find to "hit" 
            {
                Debug.Log("HIT: " + hit.transform.name);
                if ((hit.transform.name == "Piggy"))
                {
                    Piggy.SetActive(true);
                    GameManager.instance.SeeBankText();
                    Destroy(hit.collider.gameObject);
                    SpawnEnemies();
                }
            }

        }    
    }

    public void SpawnEnemies()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            GameObject enemyInst = Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
            EnemyMove move = enemyInst.GetComponent<EnemyMove>();
            move.player = gameObject.transform;

        }

    }
    
}