using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarFases : MonoBehaviour
{
    public string[] Cenas;
    public int numeroDaCena;
    void Start()
    {
        //Indicar que a cena está sendo carregada
        Debug.Log("Carregamento de cena ativado...");
    }
    void Update()
    {
    }
    public void Carregando()
    {
        Debug.Log("Estamos carregando: " + Cenas[numeroDaCena]);
        SceneManager.LoadScene(Cenas[numeroDaCena]);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Encostar no chão
        if (collision.gameObject.tag == "Player")
        {
            //Bateu trocou de fase...
            Carregando();
        }
    }
}
