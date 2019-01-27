using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour {

    public Button _ClickToContinue1;
    public Button _ClickToContinue2;
    public Button _ClickToContinue3;

    GameManager _gm;
    CanvasManager _cm;

    DialogBox _db1;
    DialogBox _db2;
    DialogBox _db3;

    // Use this for initialization
    void Start () {

        if (SceneManager.GetSceneByName("Kurts_Workspace").isLoaded)
        {
            _db1 = GameObject.Find("Canvas").GetComponentInChildren<DialogBox>();
            _db2 = GameObject.Find("Canvas").GetComponentInChildren<DialogBox>();
            _db3 = GameObject.Find("Canvas").GetComponentInChildren<DialogBox>();
        }

        if (_cm) {
            if (_ClickToContinue1)
            {
                _ClickToContinue1.onClick.AddListener(_db1.NextDialogBox1);
            }
            if (_ClickToContinue2)
            {
                _ClickToContinue2.onClick.AddListener(_db2.NextDialogBox2);
            }
            if (_ClickToContinue3)
            {
                _ClickToContinue3.onClick.AddListener(_db3.NextDialogBox3);
            }
        }
	}
}
