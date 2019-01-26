using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour {

    //public bool test;
    public ObstacleType _npcNumber;

	// Use this for initialization
	void Start () {

		if(this.npcNumber == ObstacleType.NoNpc)
        {
            Debug.LogWarning("No obstacle type selected for " + name,gameObject);
        }

        if (this.npcNumber == ObstacleType.Axe)
        {
            transform.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (this.npcNumber == ObstacleType.Fish)
        {
            transform.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (this.npcNumber == ObstacleType.Torch)
        {
            transform.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (this.npcNumber == ObstacleType.Jacket)
        {
            transform.GetComponent<Renderer>().material.color = Color.gray;
        }
        else if (this.npcNumber == ObstacleType.Rope)
        {
            transform.GetComponent<Renderer>().material.color = Color.magenta;
        }


    }


    public ObstacleType npcNumber
    {
        get { return _npcNumber; }
        private set { value = _npcNumber; }
    }

}

//public enum CurrentObstacle//Same as what the player has entered in Player interactable
//{
//    NoNpc, Axe, Fish, Torch, Jacket, Rope
//}
