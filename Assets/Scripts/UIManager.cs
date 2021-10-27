using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverPanel;

    void Start()
    {
        gameOverPanel.gameObject.SetActive(false);
    }

    public void triggerGameOver()
    {
        gameOverPanel.gameObject.SetActive(true);
    }
}
