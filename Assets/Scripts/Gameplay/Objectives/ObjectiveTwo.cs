using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveTwo : MonoBehaviour
{
    public ObjectiveThree objectiveThree;
    public GameObject barrel;

    public bool IsActive = false;

    // Update is called once per frame
    void Update()
    {
        if (IsActive)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                GameObject.Find("Gameplay/noteGameObject").SetActive(false);
                barrel.SetActive(true);
                objectiveThree.IsActive = true;
                IsActive = false;
            }
        }
    }
}
