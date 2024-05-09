using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public HealthPool playerHealth;
    public shoot piggyBank;

    public TextMeshProUGUI healthCount;
    public TextMeshProUGUI moneyCount;
    public TextMeshProUGUI textBank;
    public TextMeshProUGUI countBank;
    public TextMeshProUGUI finalScore;

    public GameObject seeText;
    public GameObject seeHealthText;
    public GameObject seeCenter;



    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        
    }


    void Start()
    {
      
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthPool>();
        piggyBank = GameObject.FindGameObjectWithTag("Piggy").GetComponent<shoot>();
    }

    public void UpdateHealthUI()
    {
        if (healthCount != null && playerHealth != null)
        {
            healthCount.text = playerHealth.hitPoints.ToString();
        }

    }

    public void UpdateBankUI()
    {
        if (moneyCount != null && piggyBank != null)
        {
            moneyCount.text = piggyBank.moneyPool.ToString();
        }
    }

    public void PrintWinScore()
    {
        if (finalScore != null && piggyBank != null)
        {
            finalScore.text = piggyBank.moneyPool.ToString() + " Pounds !";
        }
    }


    public void SeeBankText()
    {
        seeText.SetActive(true);
    }

    public void NoSeebanktext()
    {
        seeText.SetActive(false);
    }

    public void SeeHealthText()
    {
        seeHealthText.SetActive(true);
    }

    public void NoSeeHealthtext()
    {
        seeHealthText.SetActive(false);
    }

    public void SeeCenterImage()
    {
        seeCenter.SetActive(true);
    }

    public void NoSeeCenterImage()
    {
        seeCenter.SetActive(false);
    }

    
}
