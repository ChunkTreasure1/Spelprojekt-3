using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayE : MonoBehaviour
{
    public string myString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;

    private void Start()
    {
        //myText = GameObject.Find("pressENote").GetComponent<Text>();
        myText.color = Color.clear;
    }

    private void Update()
    {
        fadeText();
        if (Input.GetKeyDown(KeyCode.Escape))
        {

        }
    }

    void OnMouseOver()
    {
        displayInfo = true;
    }
    void OnMouseExit()
    {
        displayInfo = false;
    }

    void fadeText()
    {
        if (displayInfo)
        {
            myText.text = myString;
            myText.color = Color.Lerp(myText.color, Color.white, fadeTime * Time.deltaTime);
        }
        else
        {
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }

    }


}
