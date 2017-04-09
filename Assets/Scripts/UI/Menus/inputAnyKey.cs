using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inputAnyKey : MonoBehaviour {

    void Update()
    {
        if (Input.anyKeyDown)
        {
            print("A key or mouse click has been detected");
            Invoke("LoadScene", 0.5f); 
        }
           

    }
    void LoadScene()
    {
        SceneManager.LoadScene("Main Menu");
    }
}