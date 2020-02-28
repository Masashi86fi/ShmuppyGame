using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneLoader : MonoBehaviour
{
    public Slider loadBar;
    int lastLoadedScene;
    int nextTargetScene;

    public void GetLastLoadedLevel()
    {
        if(PlayerPrefs.HasKey("LastScene"))
        {
            lastLoadedScene = PlayerPrefs.GetInt("LastScene");
        }
        if (PlayerPrefs.HasKey("nextTargetScene"))
        {
            nextTargetScene = PlayerPrefs.GetInt("nextTargetScene");
        }

    }
    private void Start()
    {
        GetLastLoadedLevel();
        LoadNextLevel();
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        SceneManager.LoadScene(nextTargetScene);
        while(loadBar.value < loadBar.maxValue)
        {
            loadBar.value += Time.fixedDeltaTime;
            yield return new WaitForFixedUpdate();            
        }

        yield return null;
    }
}
