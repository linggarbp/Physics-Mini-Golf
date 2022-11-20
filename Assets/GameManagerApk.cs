using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerApk : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] Hole hole;

    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    void Update()
    {
        if (hole.Entered && gameOverPanel.activeInHierarchy == false)
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
