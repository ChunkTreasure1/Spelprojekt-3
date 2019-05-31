using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveOne : MonoBehaviour
{
    public ObjectiveTwo objectiveTwo;
    private bool IsActive = true;

    private void Update()
    {
        if (IsActive)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                objectiveTwo.IsActive = true;
                IsActive = false;
            }
        }
    }
}
