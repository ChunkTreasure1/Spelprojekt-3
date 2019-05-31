using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveFive : MonoBehaviour
{
    public AudioSource audio;
    public bool IsActive;
    Note note;

    private void Start()
    {
        note = this.GetComponent<Note>();
    }

    private void Update()
    {
        if (IsActive && note.gameIsPaused && note.page2)
        {
            audio.Play();
        }
    }
}
