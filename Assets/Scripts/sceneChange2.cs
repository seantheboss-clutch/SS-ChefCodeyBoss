using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneChange2 : MonoBehaviour
{
    public void sceneChang2(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}