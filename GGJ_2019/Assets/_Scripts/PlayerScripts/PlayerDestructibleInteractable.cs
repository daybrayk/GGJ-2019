using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestructibleInteractable : MonoBehaviour {

    //public CurrentBenefit npcBonus;

    //public delegate void OnNpcChanged(int newNpcNumber);
    //public static event OnNpcChanged onNpcChanged;

    [SerializeField]
    private bool canInteract;
    [SerializeField]
    private ObstacleType npcNumber;
    private Destructable destructible;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (canInteract)
        {
            if(Input.GetKeyDown(KeyCode.Z))
            {
                if(npcNumber == destructible.npcNumber)
                {
                    Destroy(destructible.gameObject);
                    canInteract = false;
                    destructible = null;
                }
            }
        }
	}



    private void OnTriggerEnter(Collider c)
    {
        if (c.transform.tag == "Destructible")
        {
            canInteract = true;
            destructible = c.GetComponent<Destructable>();
        }
    }

    private void OnTriggerExit(Collider c)
    {
        if (c.transform.tag == "Player")
        {
            canInteract = false;
            destructible = null;
        }
    }

}

public enum ObstacleType
{
    NoNpc, Axe, Fish, Torch, Jacket, Rope
}
