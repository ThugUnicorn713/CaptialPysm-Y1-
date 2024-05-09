using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public GameObject pinPanel;

    public void OpenPin()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        GameManager.instance.NoSeeCenterImage();
       
        pinPanel.SetActive(true); 
        gameObject.SetActive(false);
        GameManager.instance.SeeCenterImage();
    }


}
