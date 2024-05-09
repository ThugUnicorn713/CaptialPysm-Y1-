using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class PTG : MonoBehaviour
{
    public GameObject ptgPanel;
    public GameObject piggy;
    public GameObject playerObject;
    public GameObject enemy;
    public GameObject spawnPoint;
    public int enemyAmount = 10;


    public void OpenPanel()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        ptgPanel.SetActive(true);
        GameManager.instance.NoSeebanktext();
        GameManager.instance.NoSeeHealthtext();
        GameManager.instance.NoSeeCenterImage();
    }

    public void Accept()
    {
        piggy.GetComponent<shoot>().moneyPool -= 100000;
        Debug.Log("Your money is taken...");
        gameObject.SetActive(false);
        ptgPanel.SetActive(false);
        GameManager.instance.SeeBankText();
        GameManager.instance.SeeHealthText();
        GameManager.instance.SeeCenterImage();
    }

    public void Decline()
    {
        ptgPanel.SetActive(false);
        GameManager.instance.SeeBankText();
        GameManager.instance.SeeHealthText();
        GameManager.instance.SeeCenterImage();
        enemyAmount *= 2;
        SoManyEnemies();
    }

    public void SoManyEnemies()
    {
        Vector3 ranPosition = Random.insideUnitCircle * 5f;
        //ranPosition = new Vector3(ranPosition.x,0,ranPosition.y); 

        for (int i = 0; i < enemyAmount; i++) 
        {

            GameObject enemyInst = Instantiate(enemy, ranPosition + spawnPoint.transform.position, Quaternion.identity);
            EnemyMove move = enemyInst.GetComponent<EnemyMove>();
            move.player = playerObject.transform;
        }

    }
}
