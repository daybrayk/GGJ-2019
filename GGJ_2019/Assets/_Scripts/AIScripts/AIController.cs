using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : Controller {
    private StateManager m_stateManager;
	// Use this for initialization
	new void Start () {
        m_stateManager = new StateManager(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MoveToPosition(Vector3 position, float distanceThreshold = 1.0f)
    {
        Vector3 direction = (position - transform.position).normalized;
    }

    public void RotateToDirection()
    {

    }
}
