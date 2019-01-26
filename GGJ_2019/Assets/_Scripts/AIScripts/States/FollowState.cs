using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowState : BaseState {
    public Transform destination;
    public FollowState(AIController aiController) : base(aiController)
    {
        Debug.Log("Creating Follow State for " + aiController.gameObject.name);
        stateID = StateIDs.States.Follow;
        destination = aiController.avatar.followTransform;
    }

    public override void Init()
    {
        
    }

    public override void OnEnter()
    {
        
    }

    public override void OnExit()
    {
        
    }

    public override void OnUpdate()
    {
        aiController.RotateToDirection(destination.position);
        aiController.MoveToPosition(destination.position);
    }

    public override void Shutdown()
    {
        
    }
}
