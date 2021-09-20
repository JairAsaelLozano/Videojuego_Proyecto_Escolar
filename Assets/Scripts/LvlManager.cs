using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class LvlManager : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CargarJuego(string IniciarJuego)
    {
        SceneManager.LoadScene(IniciarJuego);
    }

    public void Terminar()
    {
        AppHelper.Quit();
    }

}
