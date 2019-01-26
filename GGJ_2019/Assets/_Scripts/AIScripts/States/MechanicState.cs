using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechanicState : BaseState
{

    public MechanicState(AIController aiController) : base(aiController)
    {
        Debug.Log("Creating Mechanic State for " + aiController.gameObject.name);
        stateID = StateIDs.States.Mechanic;
    }

    public override void Init()
    {
        
    }

    public override void OnEnter()
    {
        aiController.doingMechanic = true;
        aiController.StopMovement();
        aiController.StopRotation();
    }

    public override void OnExit()
    {
        
    }

    public override void OnUpdate()
    {
        aiController.doingMechanic = aiController.avatar.DoMechanic(aiController.mechanicCollider);
        
    }

    public override void Shutdown()
    {
        
    }
}
