using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorAfterPanel : MonoBehaviour
{

    public void ResetCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameManager.instance.SeeCenterImage();
    }
   
}
