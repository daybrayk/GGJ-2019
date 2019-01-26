using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{

    public IdleState(AIController aiController) : base(aiController)
    {
        Debug.Log("Creating IdleState for " + aiController.gameObject.name);
        stateID = StateIDs.States.Idle;
    }
    public override void Init()
    {
        
    }

    public override void OnEnter()
    {
        //play animation
        //stop movement
        aiController.StopMovement();
        aiController.StopRotation();
        aiController.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    public override void OnExit()
    {
        aiController.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    public override void OnUpdate()
    {

    }

    public override void Shutdown()
    {
        
    }
}
