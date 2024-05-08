using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject winPanel;
    public void GetWinPanel()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
        GameManager.instance.NoSeebanktext();
        winPanel.SetActive(true);
        GameManager.instance.PrintWinScore();
    }

    
}
