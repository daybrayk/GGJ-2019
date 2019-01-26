using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAvatar : AvatarFunctionality {
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

    public virtual bool DoMechanic(Collider c)
    {
        return true;
    }
}
