using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{

    public IdleState(AIController aiController) : base(aiController)
    {
        Debug.Log("Creating IdleState");
    }
    public override void Init()
    {
        stateID = StateIDs.States.Idle;
    }

    public override void OnEnter()
    {
        aiController.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    public override void OnExit()
    {
        
    }

    public override void OnUpdate()
    {
        
    }

    public override void Shutdown()
    {
        
    }
}
