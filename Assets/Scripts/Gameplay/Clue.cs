using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clue : MonoBehaviour
{
    [SerializeField] private string TextToShow;
    [SerializeField] private BoxCollider Area;

    private GameObject Text;
    private bool Entered = false;

    void Start()
    {
        Text = GameObject.FindGameObjectWithTag("Text");
    }

    void Update()
    {
        if (Entered)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Text.GetComponent<Text>().text = TextToShow;
            }
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            //Show interact text
            Entered = true;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Entered = false;
        }
    }
}
