using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public KeyCode input;
    private HingeJoint hinge;
    public float springPower;
    // menyimpan angka target position saat ditekan dan dilepas
        // private float targetPressed;
        // private float targetReleased;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();

        // saat Start,set kedua target dengan nilai limit min atau max 
            //targetPressed = hinge.limits.max;
            //targetReleased = hinge.limits.min;
    }

    // Update is called once per frame
    private void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        JointSpring jointSpring = hinge.spring;

        // mengubah value spring saat input ditekan dan dilepas
        if (Input.GetKey(input))
        {
            jointSpring.spring = springPower;
        }
        else
        {
            jointSpring.spring = 0;
        }

        hinge.spring = jointSpring;

        // if (Input.GetKey(input))
        //   {
        //       Debug.Log("Key Pressed");
        //   }

    }
}
