using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public bool gameIsPaused = false;
    public bool Page1 = true;
    public bool page2 = false;

    public GameObject note1;
    public GameObject note2;
    public GameObject noteMenuUI;
    public GameObject noteCanvas;
    public displayE myScript;

    private void Start()
    {
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
            if (Input.GetKeyDown(KeyCode.F) && gameIsPaused)
            {
                flipPage();
            }
        }
    }
    void Pause()
    {
        noteMenuUI.SetActive(true);
        Cursor.visible = true;
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void Resume()
    {
        Cursor.visible = false;
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
