using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
	public Button Back;
    // Start is called before the first frame update
    void Start()
    {
         Back.onClick.AddListener(toMenu);
    }

	void toMenu(){
	    	SceneManager.LoadScene("menu");
    }
    
}
