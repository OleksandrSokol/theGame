using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public Button Play;
	public Button Settings;
	public Button ExitGame;
    // Start is called before the first frame update
    void Start()
    {
        Play.onClick.AddListener(toGame);
        Settings.onClick.AddListener(toSetting);
        ExitGame.onClick.AddListener(toWindows);
    }

    void toGame(){
    	SceneManager.LoadScene("SampleScene");
    }

    void toSetting(){
    	SceneManager.LoadScene("resroshooter");
    }

    void toWindows(){
    	Application.Quit();
    }
}
