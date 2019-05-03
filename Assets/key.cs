using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject keyUI;
    public bool keyPickedUp = false;
    private displayE myScript;
    public void Start()
    {
        myScript = GetComponentInChildren<displayE>();
    }
    public void Update()
    {
        if (myScript.displayInfo == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                 pickUp();
            }
        }
    }
    public void pickUp()
    {
        keyPickedUp = true;
        keyUI.SetActive(false);
    }
}
