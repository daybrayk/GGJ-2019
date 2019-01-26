using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller {
    private AvatarFunctionality m_avatar;
	// Use this for initialization
	void Start () {
        m_avatar = GetComponent<AvatarFunctionality>();
	}
	
	// Update is called once per frame
	void Update () {
        float strafeValue = Input.GetAxisRaw("Horizontal");
        float linearValue = Input.GetAxisRaw("Vertical");
        float angularValue = Input.GetAxis("Mouse X");

        m_avatar.SetLinearRatio(linearValue);
        m_avatar.SetStrafeRatio(strafeValue);
        m_avatar.SetAngularRatio(angularValue);
	}
}
