using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState {

    public BaseState (AIController aiController)
    {
        this.aiController = aiController;
    }

    public abstract void Init();

    public abstract void Shutdown();

    public abstract void OnEnter();

    public abstract void OnUpdate();

    public abstract void OnExit();

    public StateIDs.States stateID { get; set; }
    public AIController aiController { get; set; }
}
