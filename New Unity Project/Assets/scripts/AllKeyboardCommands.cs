using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllKeyboardCommands : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }

    // Update is called once per frame
    void Update () {
		if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.P))
        {
            GetComponent<Mover>().enabled = !GetComponent<Mover>().enabled;

        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.SetActive(false);
        }
	}
}
