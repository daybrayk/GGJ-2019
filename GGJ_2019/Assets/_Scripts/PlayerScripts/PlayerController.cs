using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerAvatar))]
public class PlayerController : Controller {

    PlayerAvatar _pAvatar;

    public bool _canTalk;

    public Button _interactButton;

	// Use this for initialization
	void Start () {

        _pAvatar = GetComponent<PlayerAvatar>();


	}
	
	// Update is called once per frame
	void Update () {
        float hValue = Input.GetAxisRaw("Horizontal");
        float vValue = Input.GetAxisRaw("Vertical");
        if (_canTalk)
        {
            if (Input.GetMouseButtonDown(0)) {
                _pAvatar.TalkToPerson();
            }
        }

        //_pAvatar._linearVelocity = Input.GetAxisRaw("Vertical");
        //_pAvatar._angularVelocity = Input.GetAxisRaw("Horizontal");

        _pAvatar.SetLinearRatio(vValue);
        _pAvatar.SetAngularRatio(hValue);
        

    }

    

    private void OnTriggerEnter(Collider c)
    {
        _canTalk = true;
    }

    private void OnTriggerExit(Collider c)
    {
        _canTalk = false;
    }
}