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
       
        pinPanel.SetActive(true); 
        gameObject.SetActive(false);
    }


}
