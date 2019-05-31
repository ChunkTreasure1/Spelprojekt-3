using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject door;
    public bool IsLocked = false;
    bool inCollider = false;
    public bool IsOpen = false;

    float Value = 0;
    float TargetTime = 3f;
    float StartTime = 3f;
    float CloseValue = 0;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            inCollider = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            inCollider = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (inCollider&& !IsLocked && !IsOpen)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                IsOpen = true;
            }
        }

        if (IsOpen)
        {
            if (Value <= 100)
            {
                Value += 1;
                door.transform.Rotate(new Vector3(0, -1, 0));
            }
            else
            {
                TargetTime -= Time.deltaTime;

                if (TargetTime <= 0f)
                {
                    TimerEnded();
                }
            }
        }
    }

    void TimerEnded()
    {
        if (IsOpen)
        {
            if (CloseValue <= 100)
            {
                CloseValue += 1;
                door.transform.Rotate(new Vector3(0, 1, 0));
            }
            else
            {
                IsOpen = false;
                Value = 0;
                CloseValue = 0;
                TargetTime = StartTime;
            }
        }
    }
}
