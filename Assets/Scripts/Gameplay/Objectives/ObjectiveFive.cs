using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveFive : MonoBehaviour
{
    public AudioSource audio;
    public bool IsActive;
    Note note;
    public GameObject mannequin;
    public DoorScript door;
    public ObjectiveSix objectiveSix;
    public ExitScript[] exitScripts;

    private void Start()
    {
        note = this.GetComponent<Note>();
    }

    private void Update()
    {
        if (IsActive && note.gameIsPaused && note.page2)
        {
            audio.Play();
            mannequin.SetActive(true);
            objectiveSix.IsActive = true;
            door.IsLocked = false;
            IsActive = false;

            for (int i = 0; i < exitScripts.Length; i++)
            {
                exitScripts[i].IsActive = true;
            }

            GameObject[] arr = GameObject.FindGameObjectsWithTag("Light");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].GetComponent<Light>().enabled = false;
            }
        }
    }
}
