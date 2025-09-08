using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Scencs : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void BranchMenu()
    {
        Debug.Log("12");
        SceneManager.LoadScene("BranchWindow");
    }
}
