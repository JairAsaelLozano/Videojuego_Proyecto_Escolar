using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class Apuntador : MonoBehaviour
{
 
    Vector3 worldPosition;
    public LayerMask mask;
    public int varBalasRestantes= 13;
    public int varAliensRestantes = 10;
    public Text Balas;
    public Text Aliens;
    public AudioSource controlSonido;
    public AudioClip sonidoDisparo;
    // Update is called once per frame
    void Start()
    {
        Balas.text = varBalasRestantes.ToString(); ;
        Aliens.text = varAliensRestantes.ToString(); ;
    }
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = +5;
        worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = worldPosition;
        if(varBalasRestantes <=0)
        {
            SceneManager.LoadScene("GameOver");
        }
        if (Input.GetMouseButtonDown(0))
        {
            controlSonido.PlayOneShot(sonidoDisparo);
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, mask);
            varBalasRestantes -= 1;
            Balas.text = varBalasRestantes.ToString(); ;
            if (hit.collider != null)
            {
                Destroy(hit.transform.gameObject);
                varAliensRestantes -= 1;
                Aliens.text = varAliensRestantes.ToString(); ;
                if (varAliensRestantes <= 0)
                {
                    SceneManager.LoadScene("Victory");
                }
            }
        }
    }
}
