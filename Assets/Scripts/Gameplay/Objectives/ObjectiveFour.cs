using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveFour : MonoBehaviour
{
    public AudioSource librarySound;
    public bool IsActive;
    public Light[] lights;
    public DoorScript Door;

    public DoorScript[] KitchenDoors;

    bool TimerStarted = false;
    bool OnOff = false;
    float TargetTime = 1f;
    float StartTime = 1f;

    int TimesDone = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (IsActive)
        {
            if (other.CompareTag("Player"))
            {
                Door.IsLocked = true;
                librarySound.Play();
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
                if (!OnOff)
                {
                    for (int i = 0; i < lights.Length; i++)
                    {
                        lights[i].enabled = false;
                    }

                    OnOff = true;
                    TargetTime = StartTime;
                    TimesDone++;

                    if (TimesDone == 5)
                    {
                        TimerStarted = false;
                        Door.IsLocked = false;

                        for (int i = 0; i < KitchenDoors.Length; i++)
                        {
                            KitchenDoors[i].IsLocked = false;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < lights.Length; i++)
                    {
                        lights[i].enabled = true;
                    }
                    OnOff = false;
                    TargetTime = StartTime;
                    TimesDone++;

                    if (TimesDone == 5)
                    {
                        TimerStarted = false;
                        Door.IsLocked = false;

                        for (int i = 0; i < KitchenDoors.Length; i++)
                        {
                            KitchenDoors[i].IsLocked = false;
                        }
                    }
                }
            }
        }
    }
}
