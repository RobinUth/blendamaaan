using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody rb;
    [SerializeField] float speed;
    private Vector3 newPos;
    private Quaternion rot;
    private Vector3 rotVec;
    private CameraController camera;
    private float velox;
    private float veloy;
    private GameObject playerFront;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        camera = FindObjectOfType<CameraController>();
        if(gameObject.tag == "Player1Side")
        {
            playerFront = GameObject.FindGameObjectWithTag("Player1");
        }
        else if(gameObject.tag == "Player2Side")
        {
            playerFront = GameObject.FindGameObjectWithTag("Player2");
        }
	}
	
	// Update is called once per frame
	void Update () {
        BetterInput();
        if(gameObject.tag == "PlayerSide")
        {

        }
	}

    void BetterInput()
    {
        if (gameObject.tag == "Player1" || gameObject.tag == "Player1Side")
        {
            rb.velocity = new Vector3(speed * Input.GetAxis("Horizontal"), 0f, speed * Input.GetAxis("Vertical"));
        }
        else
        {
            rb.velocity = new Vector3(speed * -Input.GetAxis("Horizontal2"), 0f, speed * -Input.GetAxis("Vertical2"));
        }
    }

    void KeepFormation()
    {

    }
}
