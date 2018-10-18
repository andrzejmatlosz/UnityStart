using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour {

    public GameObject door;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(CloseDoorMethod());
    }

    IEnumerator CloseDoorMethod()
    {
        while (door.transform.position.y > 2)
        {
            door.transform.position = new Vector3(
                door.transform.position.x,
                door.transform.position.y - 0.1f,
                door.transform.position.z);
            yield return new WaitForSeconds(0.025f);
        }

        StopCoroutine(CloseDoorMethod());
    }
}
