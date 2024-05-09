using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ATM : MonoBehaviour
{
    public GameObject atmPanel;
    public TMP_InputField userInput;
    public int pin = 5174;
    public GameObject piggy;


    public void OpenATM()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        atmPanel.SetActive(true);
        GameManager.instance.NoSeebanktext();
        GameManager.instance.NoSeeHealthtext();
        GameManager.instance.NoSeeCenterImage();
    }

    public void CheckPin()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        

        if (userInput.text == pin.ToString())
        {
            piggy.GetComponent<shoot>().moneyPool += 1000000;
            GameManager.instance.UpdateBankUI();
            gameObject.SetActive(false); ;
            Debug.Log("1000000 added, bands on bands on bands!");
        }

        
        atmPanel.SetActive(false);
        GameManager.instance.SeeBankText();
        GameManager.instance.SeeHealthText();
        GameManager.instance.SeeCenterImage();
    }
}
