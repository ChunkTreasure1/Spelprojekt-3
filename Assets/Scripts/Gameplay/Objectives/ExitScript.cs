using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    bool IsActive = false;
    public GameObject mannequin;
    public GameObject lastMannequin;
    bool TimerStarted = false;

    float TargetTime = 3f;

    private void OnTriggerEnter(Collider other)
    {
        if (IsActive)
        {
            if (other.CompareTag("Player"))
            {
                TimerStarted = true;
            }
        }
    }

    private void Update()
    {
        if (TimerStarted)
        {
            TargetTime -= Time.deltaTime;

            if (TargetTime <= 0f)
            {
                mannequin.SetActive(true);
                lastMannequin.SetActive(false);
                TimerStarted = false;
            }
        }
    }
}
