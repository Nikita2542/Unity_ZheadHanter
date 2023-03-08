using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scene_Man_Scr : MonoBehaviour
{
    public void LoadScene_Lab()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadScene_Play()
    {
        SceneManager.LoadScene(0);
    }
}
