using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
	public GameObject Player;
	public GameObject DeadPlayer;

	void OnTriggerEnter(Collider other){
		if(other.tag == "DeadZone"){
				Player.SetActive(false);
				DeadPlayer.SetActive(true);
				Instantiate(DeadPlayer, transform.position, transform.rotation);
				//SceneManager.LoadScene("menu");
		}

	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
        	SceneManager.LoadScene("menu");
        }
    }
}
