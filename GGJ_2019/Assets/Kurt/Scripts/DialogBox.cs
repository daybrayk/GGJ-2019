using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogBox : MonoBehaviour {

    public Button _next;

    public Text _nextText;

    // Keep track of which dialog box you are on with this variable
    public float _dbCount = -1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NextDialogBox()
    {
        Debug.Log("Dialog Box Count: " + _dbCount);
        // make a sequence of dialog boxes here
        _dbCount++;

        // Create a switch/case method to use for the dialog

        if (_dbCount == 0)
        {
            _nextText.text = "Hello";
        }

        if(_dbCount == 1)
        {
            _nextText.text = "Where did you come from?";
        }

        if(_dbCount == 2)
        {
            _nextText.text = "Ah okay, I shall follow you";
        }

        if (_dbCount == 3)
        {
            _nextText.text = "What are we going to do?";
        }
    }
}