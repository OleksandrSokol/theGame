using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = (false);
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = (false);

        if(Input.GetKeyDown(KeyCode.Escape)){
        	Cursor.lockState = CursorLockMode.None;
        Cursor.visible = (true);
        }

    }
}
