using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtualButton : MonoBehaviour
{
    public GameObject ARbutton;
    public Animator bob;
    public bool state;
    public AudioSource sound1;

    // Start is called before the first frame update
    void Start()
    {
        ARbutton = GameObject.Find("Box");
        sound1 = GetComponent<AudioSource>();
        ARbutton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(Pressed);
        ARbutton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(Released);
        bob.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Pressed(VirtualButtonBehaviour vb)
    {
        bob.SetBool("isPressed", true);
        Debug.Log("Pressed");
        state = bob.GetBool("isPressed");
        if (state == true)
        {
            sound1.Play();
            Debug.Log("True");
        }
    }

    public void Released(VirtualButtonBehaviour vb)
    {
        bob.SetBool("isPressed",false);
        Debug.Log("Releassed");
        state = bob.GetBool("isPressed");
        if (state == false)
        {
            Debug.Log("False");
        }
    }
}
