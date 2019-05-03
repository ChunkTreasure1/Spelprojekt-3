using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class door : MonoBehaviour
{
    public string myString;
    public string openString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;
    private key myScript;

    // Start is called before the first frame update
    void Start()
    {
        //myText = GameObject.Find("").GetComponent<Text>();
        myText.color = Color.clear;
        myScript = GetComponent<key>();
    }

    // Update is called once per frame
    void Update()
    {
        FadeText();
    }

    private void OnMouseOver()
    {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
               displayInfo = true;
            }
    }
    private void OnMouseExit()
    {
        displayInfo = false;
    }
    void FadeText()
    {
        if (displayInfo)
        {
            if (myScript.keyPickedUp==true)
            {
                myText.text = openString;
            }
            else
            {
                myText.text = myString;
            }

            myText.color = Color.Lerp(myText.color, Color.white, fadeTime * Time.deltaTime);
        }
        else
        {
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }
}
