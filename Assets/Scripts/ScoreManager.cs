using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    private int scoreBlue;
    private int scoreOrange;
    private Vector3 originPos;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        originPos = transform.position;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "BlueLine")
        {
            scoreOrange++;
        }
        else if(other.tag == "OrangeLine")
        {
            scoreBlue++;
        }
        else if(other.tag == "BallRespawn")
        {
            ResetBall();
        }
    }

    void ResetBall()
    {
        transform.position = originPos;
        rb.velocity = Vector3.zero;
    }

}
