using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour {

    public Transform ch;
    public float speed;
	
	// Update is called once per frame
	void Update () {
        //ch.position = new Vector3(0, ch.position.y * speed * Time.deltaTime, 0);
        ch.transform.Translate(Vector3.up * speed * Time.deltaTime);
            if(ch.position.y >= 0) speed = 0f;
	}
}
