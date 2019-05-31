using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveThree : MonoBehaviour
{
    public bool IsActive = false;
    public AudioSource audio;
    public AudioSource screamSound;

    private void OnTriggerEnter(Collider other)
    {
        if (IsActive)
        {
            if (other.CompareTag("Player"))
            {
                audio.Play();
                Timer();
                GameObject.Find("Gameplay/noteGameObject1").SetActive(false);
                IsActive = false;
            }
        }
    }

    IEnumerator Timer()
    {
        while(true)
        {
            yield return new WaitForSeconds(3f);

            screamSound.Play();
            break;
        }
    }
}
