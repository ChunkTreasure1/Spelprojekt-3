using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveSix : MonoBehaviour
{
    DoorScript door;
    public bool IsActive = false;

    // Start is called before the first frame update
    void Start()
    {
        door = this.GetComponent<DoorScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (door.IsOpen && IsActive)
        {
            //KILL PLAYER
            Debug.Log("Player killed");
        }
    }
}
