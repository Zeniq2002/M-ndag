using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    public float timerText;
    public float timer;
    public float secunder = 1;

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(secunder);

        timerText = timerText + Time.deltaTime;
        if (timerText >= secunder)
        {
            print(timerText);
            secunder = secunder + 1;
        }
	}
}
