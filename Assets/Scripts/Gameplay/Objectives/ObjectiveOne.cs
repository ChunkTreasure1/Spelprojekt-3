using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveOne : MonoBehaviour
{
    public ObjectiveTwo objectiveTwo;
    public DoorScript door;
    private bool IsActive = true;
    Note note;

    private void Start()
    {
        note = this.GetComponent<Note>();
    }

    private void Update()
    {
        if (IsActive && note.gameIsPaused)
        {
            if (note.page2)
            {
                door.IsLocked = false;
                objectiveTwo.IsActive = true;
                IsActive = false;
            }
        }
    }
}
