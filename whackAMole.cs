using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whackAMole : MonoBehaviour
{
    public GameObject mole1;
    public GameObject mole2;
    public GameObject mole3;
    public GameObject mole4;
    Vector3 mole11;
    Vector3 mole12;
    Vector3 mole13;
    Vector3 mole14;
    void Start()
    {
       mole11=mole1.transform.position;
       mole12=mole2.transform.position;
       mole13=mole3.transform.position;
       mole14=mole4.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.JoystickButton0))
        {
            mole3.transform.position = new Vector3(330.910004f, 69.9300003f, -449.779999f);
        }
        if (Input.GetKey(KeyCode.JoystickButton0)==false)
        {
            mole3.transform.position = mole12;
            
        }
        if (Input.GetKey(KeyCode.JoystickButton1))
        {
            mole2.transform.position = new Vector3(329.200012f, 71.6699982f, -447.600006f);
        }
        if (Input.GetKey(KeyCode.JoystickButton1) == false)
        {
            mole2.transform.position = mole12;
        }
        if (Input.GetKey(KeyCode.JoystickButton2))
        {
            mole1.transform.position = new Vector3(326.649994f, 70.4100037f, -449.429993f);
        }
        if (Input.GetKey(KeyCode.JoystickButton2) == false)
        {
            mole1.transform.position = mole11;
        }
        if (Input.GetKey(KeyCode.JoystickButton3))
        {
            
        }
        if (Input.GetKey(KeyCode.JoystickButton3) == false)
        {
            
        }
    }
}
