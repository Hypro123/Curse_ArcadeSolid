using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController2 : MonoBehaviour
{
    HingeJoint hing;
    JointMotor motor;

    /*
     traget force for the opposite paddle needs
     to be -1000
     and the min limite needs to be -40
     */
    
	// Use this for initialization
	void Start ()
    {
        hing = GetComponent<HingeJoint>();
        motor = hing.motor;
        ////motor.force = 100;
        //motor.targetVelocity = 1000;
        motor.freeSpin = false;
        //hing.motor = motor;
        //hing.useMotor = true;
	}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("Righty");
            hing.useMotor = true;
            motor.force = 10000;
            hing.motor = motor;
        }
    }

}
