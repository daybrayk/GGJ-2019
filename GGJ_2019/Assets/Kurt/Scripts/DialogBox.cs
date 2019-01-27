using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogBox : MonoBehaviour {

    public Button _next1;
    public Button _next2;
    public Button _next3;

    public Text _axeText;
    public Text _ropeText;
    public Text _torchText;

    NPC_Clicker npc_Clicker;

    //public GameObject _dialogBoxPanel;

    // Keep track of which dialog box you are on with this variable
    public int _dbCount1 = -1;
    public int _dbCount2 = -1;
    public int _dbCount3 = -1;

    public enum NPC
    {
        Axe,
        Rope,
        Torch
    };

    public NPC npc;

    // Use this for initialization
    void Start () {
        npc_Clicker = GameObject.Find("Main Camera").GetComponent<NPC_Clicker>();
	}
	
	// Update is called once per frame
	void Update () {
		
        switch (npc) {

            case NPC.Axe:

                switch (_dbCount1)
                {                    
                    case 0:
                        _axeText.text = "Axel: Where did you come from? Where are we?";
                        break;

                    case 1:
                        _axeText.text = "Self: I'm not sure, I woke up at a camp without a clue";
                        break;

                    case 2:
                        _axeText.text = "Self: I think we should stick together";
                        break;

                    case 3:
                        _axeText.text = "Axel: I'm scared, I agree!";
                        break;

                    case 4:
                        _axeText.text = "Self: Would you like me to bring you to my camp?";
                        break;

                    case 5:
                        _axeText.text = "Axel: Yes, thank you!";
                        break;
                    case 6:
                        _axeText.text = "Axel: Here, take this";
                        break;
                    case 7:                        
                        _axeText.text = "You have obtained an Axe";
                        break;
                    case 8:
                        npc_Clicker._dialogBoxPanel1.SetActive(false);                        
                        _dbCount1 = -1;
                        break;
                }
                break;

            case NPC.Rope:

                switch (_dbCount2)
                {
                    case 0:
                        _ropeText.text = "Robert: What happened? I'm scared";
                        break;

                    case 1:
                        _ropeText.text = "Self: I'm not sure, I woke up at a camp without a clue";
                        break;

                    case 2:
                        _ropeText.text = "Robert: What do you mean?";
                        break;

                    case 3:
                        _ropeText.text = "Self: We should get out of here before something bad happens";
                        break;

                    case 4:
                        _ropeText.text = "Robert: Where will we go?";
                        break;

                    case 5:
                        _ropeText.text = "Self: I'll bring you to the camp that I woke up at. We'll be safe there";
                        break;
                    case 6:
                        _ropeText.text = "Robert: Okay, you have a good point. Let's get out of here!";
                        break;
                    case 7:
                        _ropeText.text = "Robert: Here, take this";                        
                        break;
                    case 8:                        
                        _ropeText.text = "You have obtained a Rope";
                        break;
                    case 9:
                        npc_Clicker._dialogBoxPanel2.SetActive(false);
                        _dbCount2 = -1;
                        break;
                }
                break;

            case NPC.Torch:

                switch (_dbCount3)
                {
                    case 0:
                        _torchText.text = "Jorge: What is this place?!";
                        break;

                    case 1:
                        _torchText.text = "Self: I couldn't really tell you..";
                        break;

                    case 2:
                        _torchText.text = "Jorge: Well that's not helpful";
                        break;

                    case 3:
                        _torchText.text = "Self: I realize that.. I think we should head to my camp where I woke up";
                        break;

                    case 4:
                        _torchText.text = "Jorge: Why would I do that?";
                        break;

                    case 5:
                        _torchText.text = "Self: Because it's much safer there";
                        break;
                    case 6:
                        _torchText.text = "Jorge: I don't know if I trust you, so I'll keep an eye on you";
                        break;
                    case 7:
                        _torchText.text = "Self: Let's go quickly";
                        break;
                    case 8:
                        _torchText.text = "Jorge: Here, take this";                        
                        break;
                    case 9:                        
                        _torchText.text = "You have obtained a Torch";
                        break;
                    case 10:
                        npc_Clicker._dialogBoxPanel3.SetActive(false);
                        _dbCount3 = -1;
                        break;
                }
                break;

            default:
                break;
        }
	}

    public void NextDialogBox1()
    {
        Debug.Log("Dialog Box Count: " + _dbCount1);        
        _dbCount1++;        
    }

    public void NextDialogBox2()
    {
        Debug.Log("Dialog Box Count: " + _dbCount2);
        _dbCount2++;
    }

    public void NextDialogBox3()
    {
        Debug.Log("Dialog Box Count: " + _dbCount3);
        _dbCount3++;
    }

    public void AxePerson()
    {
        Debug.Log("Axe Person");
        
        NextDialogBox1();
    }

    public void RopePerson()
    {
        Debug.Log("Rope Person");
        
        NextDialogBox2();
    }

    public void TorchPerson()
    {
        Debug.Log("Torch Person");
        
        NextDialogBox3();
    }
}