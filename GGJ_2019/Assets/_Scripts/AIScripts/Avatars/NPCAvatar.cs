using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAvatar : AvatarFunctionality {
    public Transform followTransform;
	// Use this for initialization
	new protected void Start ()
    {
        base.Start();
	}
	
	// Update is called once per frame
	new protected void FixedUpdate()
    {
        base.FixedUpdate();
    }

    public virtual void DoMechanic()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
