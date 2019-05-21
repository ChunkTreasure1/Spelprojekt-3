using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public static bool Page1 = true;
    public static bool page2 = false;
    private displayE myScript;

    public GameObject note1;
    public GameObject note2;
    public GameObject noteMenuUI;
    public GameObject noteCanvas;

    private void Start()
    {
        myScript = noteCanvas.GetComponent<displayE>();
    }

    void Update()
    {
        if (myScript.displayInfo == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
               if (gameIsPaused)
               {
                    Resume();
               }
               else
               {
                    Pause();
               }
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (gameIsPaused)
                {
                    Resume();
                }
            }
        }
    }
    void Pause()
    {
        noteMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void Resume()
    {
        noteMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    public void flipPage()
    {
        if (Page1==true)
        {
            Page1 = false;
            note1.SetActive(false);
            page2 = true;
            note2.SetActive(true);
        }
        else
        {
            page2 = false;
            note2.SetActive(false);
            Page1 = true;
            note1.SetActive(true);
        }
    }
}
