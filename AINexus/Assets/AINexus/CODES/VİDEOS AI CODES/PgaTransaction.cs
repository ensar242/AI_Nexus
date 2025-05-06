using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PgaTransaction : MonoBehaviour
{
    public void StartScene()
    {
        SceneManager.LoadScene("StartScene");

    }

    public void MainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void VideoScene()
    {
        SceneManager.LoadScene("VideoScene");
    }

}
