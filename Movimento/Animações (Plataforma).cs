//Isto é apenas um código, no Unity temos outros passos a seguir...

Animator animador;

Rigidbody2D gravidade;
public float horizontal;
public bool noChao, pulando, puloDuplo, queda;

void Animacoes()
    {
        horizontal = gravidade.velocity.x;

        if (horizontal == 0 && noChao) // Parado
        {
            animador.SetBool("Correndo", false);
            animador.SetBool("Pulando", false);
            animador.SetBool("Caindo", false); 
        }
        else if (horizontal != 0 && noChao) // Anando
        {
            animador.SetBool("Correndo", true);      
        }
        else if (puloDuplo && pulando) // Pulando
        {
            animador.SetBool("Pulando", true);
            animador.SetBool("Caindo", false);
            animador.SetBool("Correndo", false);   
        }
    }
//Não esqueça de chamar Animacoes() no método Update!
