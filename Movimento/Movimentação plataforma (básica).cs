using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joog : MonoBehaviour
{
    Rigidbody2D gravidade;
    public float horizontal, vertical, velocidade;
    void Start()
    {
        //gravidade receberá o componente Rigidbody do nosso objeto
        gravidade = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
    }
    void Movimento()
    {
        //Movimentos horizontais recebe velocidade quando clicamos nas teclas "Horizontais"
        horizontal = Input.GetAxisRaw("Horizontal") * velocidade;
        //Movimentos verticais recebem a velocidade da gravidade atuando sobre eles de forma vertical
        vertical = gravidade.velocity.y;

        //A velocidade da gravidade receberá novos movimentos verticais e horizontais de acordo com o que escrevemos acima
        gravidade.velocity = new Vector2(horizontal, vertical);

        //Mudando o ângulo horizontal do Personagem
        if (horizontal > 0)
        {
            //Com base no ângulo do componente transform, o sprite receberá o ângulo 
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (horizontal < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}
