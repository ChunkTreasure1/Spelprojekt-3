using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveTwo : MonoBehaviour
{
    public ObjectiveThree objectiveThree;
    public GameObject barrel;

    Note note;
    public bool IsActive = false;

    private void Start()
    {
        note = this.GetComponent<Note>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsActive && note.gameIsPaused && note.page2)
        {
            GameObject.Find("Gameplay/noteGameObject").SetActive(false);
            barrel.SetActive(true);
            objectiveThree.IsActive = true;
            IsActive = false;
        }
    }
}
