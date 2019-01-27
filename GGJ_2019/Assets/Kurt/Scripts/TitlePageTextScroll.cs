using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitlePageTextScroll : MonoBehaviour {

    public Text _titleText1;
    public Text _titleText2;
    public Text _titleText3;
    public Text _titleText4;
    public Text _titleText5;
    public Text _titleText6;

    Text _displayingText;

    public Transform endPoint;

    CanvasManager _cm;
    GameManager _gm;

    public float scrollTimer = 2f;
    public float waitTimer = 0f;
    public float displayTimer;

    [SerializeField] bool startTimer;

    private void Start() {
        _cm = GetComponentInParent<CanvasManager>();
        _gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        displayTimer = 2f;
        //waitTimer += Time.deltaTime;
    }

    private void Update() {

                    ScrollingText(_titleText1);
                    _displayingText.text = " " + _displayingText.ToString();
                    //_displayingText.text = new Vector3(Mathf.SmoothStep(this.transform.position.x, endPoint.position.x, scrollTimer), 0f, 0f);

        if (startTimer)
        {
            waitTimer += Time.deltaTime;
        }

        if (waitTimer < Mathf.Epsilon && displayTimer > Mathf.Epsilon)
        {
            startTimer = true;

            if (waitTimer > 3f)
            {
                displayTimer -= Time.deltaTime;
                Debug.Log("Display Timer: " + displayTimer.ToString());

                if(waitTimer > displayTimer)
                {
                    scrollTimer += Time.deltaTime;
                    waitTimer = 0f;
                    displayTimer = 3f;
                    startTimer = false;
                }                

                else if(waitTimer > displayTimer)
                {
                    ScrollingText(_titleText2);
                    _displayingText.text = " " + _displayingText;
                }

                else if (waitTimer > displayTimer)
                {
                    ScrollingText(_titleText3);
                    _displayingText.text = " " + _displayingText;
                }

                else if (waitTimer > displayTimer)
                {
                    ScrollingText(_titleText4);
                    _displayingText.text = " " + _displayingText;
                }

                else if (waitTimer > displayTimer)
                {
                    ScrollingText(_titleText5);
                    _displayingText.text = " " + _displayingText;
                }

                else if (waitTimer > displayTimer)
                {
                    ScrollingText(_titleText6);
                    _displayingText.text = " " + _displayingText;
                }

                else
                {
                    SceneManager.LoadScene("Kurts_Workspace");
                }

            }

            if (scrollTimer >= 2f)
            {
                _displayingText.transform.Translate(0f, 0f, 0f);                
            }
        }


        
    }

    void ScrollingText(Text text)
    {
        _displayingText = text;
    }

    void GetTextInOrder()
    {
        
    }
}