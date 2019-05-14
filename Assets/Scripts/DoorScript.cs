using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Animator animator;
    bool inCollider = false;
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
        if (inCollider == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                animator.SetBool("IsOpen", true);
            }
        }
    }
}
