using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectiveSix : MonoBehaviour
{
    DoorScript door;
    public bool IsActive = false;
    public GameObject panel;

    float TargetTime = 3f;
    bool TimerStarted = false;
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
            panel.SetActive(true);
            TimerStarted = true;
        }

        if (TimerStarted)
        {
            TargetTime -= Time.deltaTime;

            if (TargetTime <= 0f)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
