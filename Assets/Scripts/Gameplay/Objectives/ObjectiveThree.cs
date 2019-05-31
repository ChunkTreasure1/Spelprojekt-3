using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveThree : MonoBehaviour
{
    public ObjectiveFour objectiveFour;
    public bool IsActive = false;
    public AudioSource audio;
    public AudioSource screamSound;

    bool TimerStarted = false;
    float TargetTime = 3f;

    private void OnTriggerEnter(Collider other)
    {
        if (IsActive)
        {
            if (other.CompareTag("Player"))
            {
                audio.Play();
                TimerStarted = true;
                GameObject.Find("Gameplay/noteGameObject1").SetActive(false);
                objectiveFour.IsActive = true;
                IsActive = false;
            }
        }
    }

    private void Update()
    {
        if (TimerStarted)
        {
            TargetTime -= Time.deltaTime;

            if (TargetTime <= 0)
            {
                screamSound.Play();
                TimerStarted = false;
            }
        }
    }
}
