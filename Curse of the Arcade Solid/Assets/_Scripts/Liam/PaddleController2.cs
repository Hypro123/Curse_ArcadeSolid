using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController2 : MonoBehaviour
{
    HingeJoint hing;
    JointMotor motor;
    JointSpring HingSpring;

    /* traget force for the opposite paddle needs
     to be -1000
     and the min limite needs to be -40 */
    
	// Use this for initialization
	void Start ()
    {
        hing = GetComponent<HingeJoint>();
        motor = hing.motor;
        motor.freeSpin = false;
	}

    // Update is called once per frame
    void Update()
    {
        hing.useMotor = false;
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            hing.useMotor = true;
            motor.force = 10000;
            hing.motor = motor;
        }
        else
        {
            hing.useSpring = true;
           // HingSpring = hing.spring;
           // HingSpring.spring = 20;
           // HingSpring.targetPosition = -40;
           // hing.spring = HingSpring;
        }
    }
}
