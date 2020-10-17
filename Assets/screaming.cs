using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screaming : MonoBehaviour
{
    public AudioSource scream;

    // Start is called before the first frame update
    void Start()
    {
        scream = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        scream.Play();
    }
}
