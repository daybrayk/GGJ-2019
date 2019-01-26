using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatar : AvatarFunctionality
{

    PlayerController _pc;

    Vector3 _strafeVelocity = Vector3.zero;

    new protected void Start()
    {
        base.Start();

         _pc = GetComponent<PlayerController>();        

        
    }

    // Update is called once per frame
    new protected void FixedUpdate()
    {
        base.FixedUpdate();
    }



    public void TalkToPerson()
    {
        // Talking to NPC - Dialog Box - Click to continue?

        // pull up the dialog on screen (Have options based on NPC script)

        // Make canvas appear from a script


    }

    // Turning on a light
    // 

    private void OnMouseOver()
    {
        // Illuminate NPC to show that the player can interact
        OnMouseDown();
    }

    private void OnMouseDown()
    {
        // pop up dialog box that initializes the conversation with the player

    }

    public void Rotate(float val)
    {
        //m_rb.AddTorque(Vector3.up * m_angularSpeed * val);
    }
}
// panel with text for conversation
// 