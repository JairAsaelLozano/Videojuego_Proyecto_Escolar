using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoInicio : MonoBehaviour
{
    public AudioSource controlSonido;
    public AudioClip sonidoDisparo;
    // Start is called before the first frame update
    void Start()
    {
        controlSonido.PlayOneShot(sonidoDisparo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
