using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitlePageTextScroll : MonoBehaviour {
        
    //public void StartGame()
    //{
    //    SceneManager.LoadScene("Kurts_Workspace");
    //}

    public IEnumerator StartingTheGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Kurts_Workspace");
    }
}