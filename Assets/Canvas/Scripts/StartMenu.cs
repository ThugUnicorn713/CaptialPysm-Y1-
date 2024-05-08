using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] string playStory = "StoryScene";
    public void StoryTime()
    {
        SceneManager.LoadScene(playStory);
    }


    // Update is called once per frame
    public void QuitGame()
    {
        Debug.Log("they gave up");
        Application.Quit();
    }
}
