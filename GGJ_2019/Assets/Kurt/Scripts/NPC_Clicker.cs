using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Clicker : MonoBehaviour {

    public DialogBox _dialog;

    public LayerMask mask1;
    public LayerMask mask2;
    public LayerMask mask3;

    public GameObject _dialogBoxPanel1;
    public GameObject _dialogBoxPanel2;
    public GameObject _dialogBoxPanel3;

    // Use this for initialization
    void Start () {
        //_dialog = GameObject.Find("Canvas").GetComponentInChildren<DialogBox>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f, mask1))
            {
                Debug.Log("Getting here?");
                if (hit.transform != null && hit.collider.tag == "AxePerson")
                {
                    _dialogBoxPanel1.SetActive(true);
                    _dialog.AxePerson();
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f, mask2))
            {
                if (hit.transform != null && hit.collider.tag == "RopePerson")
                {
                    _dialogBoxPanel2.SetActive(true);
                    _dialog.RopePerson();
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f, mask3))
            {
                if (hit.transform != null && hit.collider.tag == "TorchPerson")
                {
                    _dialogBoxPanel3.SetActive(true);
                    _dialog.TorchPerson();
                }
            }
        }
    }
}