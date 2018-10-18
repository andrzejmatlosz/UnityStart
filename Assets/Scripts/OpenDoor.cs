using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

    public GameController gameController;
    public GameObject door;

    private float velocity;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update () {
        
	}

    private void OnTriggerEnter(Collider other)
    {
        if (gameController.canOpenDoor)
        {
            StartCoroutine(OpenDoorMethod());
        }
    }

    IEnumerator OpenDoorMethod()
    {
        while (door.transform.position.y < 6)
        {
            door.transform.position = new Vector3(
                door.transform.position.x,
                door.transform.position.y + 0.1f,
                door.transform.position.z);
            yield return new WaitForSeconds(0.025f);
        }

        StopCoroutine(OpenDoorMethod());
    }
}
