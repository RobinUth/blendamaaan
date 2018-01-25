using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    private PlayerController player;
    private Vector3 offset;
    private GameObject ball;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
        offset = transform.position - player.gameObject.transform.position;
        //ball = FindObject
    }
	
	// Update is called once per frame
	void Update () {
        /*
        transform.position = player.gameObject.transform.position + offset;
        transform.Rotate(new Vector3(0f, player.gameObject.transform.rotation.eulerAngles.y, 0f));
        transform.rotation = Quaternion.(0f, player.gameObject.transform.rotation.y, 0f);//player.gameObject.transform.rotation;
        transform.rotation = transform.rotation * new Quaternion(-4f, 0f, 0f, 0f);
        */
    }

    private void LateUpdate()
    {
        /*
        transform.rotation = Quaternion.Euler(new Vector3(30f, player.transform.rotation.eulerAngles.y, 0f));
        if (player.transform.rotation.y <= -89 && player.transform.rotation.y >= -91)
        {
            transform.Rotate(new Vector3(30f, 180f, 0f));
        }
        else if (player.transform.rotation.y >= 89 && player.transform.rotation.y <= 91)
        {
            transform.Rotate(new Vector3(30f, 0f, 0f));
        }
        */
    }
}
