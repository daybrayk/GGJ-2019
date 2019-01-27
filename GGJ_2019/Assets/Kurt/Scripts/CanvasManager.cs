using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour {
        
    public GameObject CreditsPanel;

    public Button _ClickToContinue;
    public Button _StartGame;
    public Button _Credits;

    GameManager _gm;
    CanvasManager _cm;

    DialogBox _db;

	// Use this for initialization
	void Start () {

        if (SceneManager.GetSceneByName("Kurts_Workspace").isLoaded)
        {
            _db = GameObject.Find("ClickToContinue").GetComponent<DialogBox>();
        }

        if (_gm) {
            if (_StartGame) {
                _StartGame.onClick.AddListener(_gm.StartGame);
            }
        }

        if (_cm) {
            if (_Credits)
            {
                _Credits.onClick.AddListener(_cm.Credits);
            }
            if (_ClickToContinue)
            {
                _ClickToContinue.onClick.AddListener(_db.NextDialogBox);
            }
        }
	}
	    
    public void Credits()
    {
        CreditsPanel.SetActive(true);
    }
}
