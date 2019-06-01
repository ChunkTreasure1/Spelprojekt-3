using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    public bool IsActive = false;
    public GameObject mannequin;
    public GameObject lastMannequin;

    private void OnTriggerEnter(Collider other)
    {
        if (IsActive)
        {
            if (other.CompareTag("Player"))
            {
                mannequin.SetActive(true);
                lastMannequin.SetActive(false);
                IsActive = false;
            }
        }
    }
}
