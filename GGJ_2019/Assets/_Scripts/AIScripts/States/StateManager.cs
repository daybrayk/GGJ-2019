﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager {

    private List<BaseState> m_state = new List<BaseState>();
    private BaseState m_currentState;

    public StateManager(AIController aiController)
    {
        Debug.Log("Creating StateManager");
        this.aiController = aiController;
        Debug.Assert(this.aiController, "IdleState NULL AICONTROLLER");
        desiredState = StateIDs.States.Invalid;
    }
    public void Shutdown()
    {

    }

    public void Update()
    {
        if(desiredState != StateIDs.States.Invalid)
        {
            ChangeState(desiredState);
            desiredState = StateIDs.States.Invalid;
        }

        if(m_currentState != null)
        {
            m_currentState.OnUpdate();
        }
    }

    public void AddState(StateIDs.States state)
    {
        switch (state)
        {
            case StateIDs.States.Idle:
                break;
        }
    }

    public void RemoveState(StateIDs.States state)
    {

    }

    private void ChangeState(StateIDs.States toState)
    {
        foreach(BaseState s in m_state)
        {
            if(s.stateID == toState)
            {
                if(m_currentState != null)
                {
                    m_currentState.OnExit();
                }
                Debug.Log("Changing state to " + toState);
                m_currentState = s;
                m_currentState.OnEnter();
                break;
            }

        }
    }

    public StateIDs.States desiredState { get; set; }
    public AIController aiController { get; set; }
    
}