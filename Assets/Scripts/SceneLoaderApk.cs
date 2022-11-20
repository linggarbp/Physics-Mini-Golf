using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderApk : MonoBehaviour
{
    public void LoadingProgress()
    {
        SceneManager.LoadScene("LoadingProgressApk");
    }
}
