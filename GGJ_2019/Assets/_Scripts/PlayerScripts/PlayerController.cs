using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerAvatar))]
public class PlayerController : Controller {

    PlayerAvatar _pAvatar;

    public bool _canTalk;

    // public Button _interactButton;

    public Camera cam;

	// Use this for initialization
	void Start () {

        _pAvatar = GetComponent<PlayerAvatar>();

        cam = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {
        cam.transform.position = new Vector3(this.transform.position.x, cam.transform.position.y, this.transform.position.z - 20f);

        float hValue = Input.GetAxisRaw("Horizontal");
        float vValue = Input.GetAxisRaw("Vertical");

        _pAvatar.SetLinearRatio(vValue);
        _pAvatar.SetAngularRatio(hValue);
    }
}