using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject ball;
    public GameObject eyes;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonDown(0))
        {
            var newBall = Instantiate(ball, eyes.transform.position, eyes.transform.rotation);
            var ballRigidBody = newBall.GetComponent<Rigidbody>();
            ballRigidBody.AddForce(eyes.transform.forward * 500);
            Destroy(newBall, 5); 
        }
	}
}
