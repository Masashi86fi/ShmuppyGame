using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchScene(int index)
    {
        PlayerPrefs.SetInt("LastScene",SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.SetInt("nextTargetScene", index);
        SceneManager.LoadScene("LoaderScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
