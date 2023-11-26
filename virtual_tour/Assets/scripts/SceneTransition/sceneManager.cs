using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneManager : MonoBehaviour
{
    public void OnClickGotoView()
    {
        SceneManager.LoadScene("view");
    }

    public void OnClickGotoCreate()
    {
        SceneManager.LoadScene("create");
    }
}
