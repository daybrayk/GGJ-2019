using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : Controller {
    public Transform followTransform;
    public bool doingMechanic;
    [SerializeField]
    private float m_distanceThreshold;
    private StateManager m_stateManager;
    [SerializeField]
    private Collider m_mechanicCollider;
    private NPCAvatar m_avatar;
	// Use this for initialization
	void Start () {
        m_avatar = GetComponent<NPCAvatar>();
        m_stateManager = new StateManager(this);
        m_stateManager.AddState(StateIDs.States.Follow);
        m_stateManager.AddState(StateIDs.States.Idle);
        m_stateManager.AddState(StateIDs.States.Mechanic);
        m_stateManager.desiredState = StateIDs.States.Follow;
	}
	
	// Update is called once per frame
	void Update () {
        m_stateManager.Update();
        if(!doingMechanic)
        {
            if (Vector3.Distance(followTransform.position, transform.position) > m_distanceThreshold)
            {
                m_stateManager.desiredState = StateIDs.States.Follow;
            }
            else
                m_stateManager.desiredState = StateIDs.States.Idle;
            if(Input.GetKeyDown(KeyCode.T))
            {
                m_stateManager.desiredState = StateIDs.States.Mechanic;
            }
        }
	}

    public void MoveToPosition(Vector3 position, float distanceThreshold = 1.0f)
    {
        Vector3 direction = (position - transform.position).normalized;
        m_avatar.SetLinearRatio(1);
        m_avatar.SetStrafeRatio(0);
    }

    public void RotateToDirection(Vector3 position, float angleThreshold = 10.0f)
    {
        Vector3 direction = (position - transform.position).normalized;
        float angleToTargetPos = Vector3.Angle(transform.forward, direction);
        if(angleToTargetPos < angleThreshold)
        {
            StopRotation();
        }
        Vector3 perp = Vector3.Cross(transform.forward, direction);
        bool isOnRight = Vector3.Dot(perp, transform.up) > 0f ? true : false;

        float maxRotation = 90.0f;
        float turnRatio = Mathf.Clamp(angleToTargetPos / maxRotation, 0, 1);
        turnRatio *= isOnRight ? 1 : -1;
        m_avatar.SetAngularRatio(turnRatio);
    }

    public void StopMovement()
    {
        m_avatar.SetLinearRatio(0);
        m_avatar.SetStrafeRatio(0);
    }

    public void StopRotation()
    {
        m_avatar.SetAngularRatio(0);
    }

    public NPCAvatar avatar
    {
        get { return m_avatar; }
    }

    public Collider mechanicCollider
    {
        get { return m_mechanicCollider; }
    }
    private void OnTriggerEnter(Collider other)
    {
        m_mechanicCollider = other;
    }
    private void OnTriggerExit(Collider other)
    {
        m_mechanicCollider = null;
    }
}
