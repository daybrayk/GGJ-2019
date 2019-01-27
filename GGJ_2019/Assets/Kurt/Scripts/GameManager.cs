using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    static private GameManager gameManager = null;

	// Use this for initialization
	void Start () {
		if(_gameManager)
        {
            Destroy(gameObject);
        }
        else
        {
            _gameManager = this;
            DontDestroyOnLoad(this);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
        SceneManager.LoadScene("Kurts_Workspace");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public static GameManager _gameManager
    {
        get { return gameManager; }
        set { gameManager = value; }
    }
}