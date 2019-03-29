using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrouch : MonoBehaviour
{
    CharacterController charactercolider;
    // Start is called before the first frame update
    void Start()
    {
        charactercolider = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftControl))
        {
            charactercolider.height = 1.0f;
        }
        else
        {
            charactercolider.height = 2.0f;
        }
    }
}
