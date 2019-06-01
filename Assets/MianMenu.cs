using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MianMenu : MonoBehaviour
{
    public void PlayGame()
    {
        sceneManager.LoadScene(SceneManager.GetActiveScene().BuildIndex + 1);
    }
}
