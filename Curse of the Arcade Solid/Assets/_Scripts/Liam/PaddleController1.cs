﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController1 : MonoBehaviour
{
    HingeJoint hing;
    JointMotor motor;
    [SerializeField]
    private AudioSource Asource;
    [SerializeField]
    private AudioClip Aclip;
    [SerializeField][Range(0, 1.0f)]
    private float volume = 0.5f;
    //JointSpring HingSpring;

    /* traget force for the opposite paddle needs
     to be -1000
     and the min limite needs to be -40 */

    // Use this for initialization
    void Start ()
    {
        if (Asource != null)
        {
            Asource.clip = Aclip;
            Asource.volume = volume;
        }

        hing = GetComponent<HingeJoint>();
        motor = hing.motor;
        motor.freeSpin = false;
	}
    // Update is called once per frame
    void Update()
    {
        hing.useMotor = false;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))// && !GameObject.FindGameObjectWithTag("GameManager").GetComponent<winCondition>().getEndGame())
        {
            hing.useMotor = true;
            motor.force = 10000;
            hing.motor = motor;
            if(Asource != null)
            {
                Asource.PlayOneShot(Aclip, volume);
            }
           
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
