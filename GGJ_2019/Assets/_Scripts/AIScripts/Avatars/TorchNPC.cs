using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchNPC : NPCAvatar {

    public Light torch;

	// Use this for initialization
	new void Start () {
        base.Start();	
	}

    // Update is called once per frame
    new void FixedUpdate()
    {
        base.FixedUpdate();

        
    }

    public override bool DoMechanic(Collider c)
    {
        base.DoMechanic(c);

        torch.enabled = !torch.enabled;
        return false;
    }
}