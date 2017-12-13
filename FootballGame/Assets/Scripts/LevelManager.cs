using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    
public void LoadNewScene(string sceneName)
{
    SceneManager.LoadScene("Level1Scene");
}

public void QuitGame()
{
    UnityEditor.EditorApplication.isPlaying = false;
}

// Use this for initialization
void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
