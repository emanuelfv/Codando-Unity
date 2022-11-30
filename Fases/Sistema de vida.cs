#region Sistema de vida
    //Aparecer na tela
    void OnGUI()
    {
        //Carregar sistema de vida
        Vida();       
    }
    void Vida()
    {
        //Colocar texto na tela
        GUI.Label(new Rect(10, 10, 200, 50), $"Você tem {vida} pontos de vida");
        if (vida < 1)
        {
            //Se morrer chamar função de morte
            Morte();
        }
    }
    void Morte()
    {
        //Sair efeito
        posicaoDeParticula.position = new Vector3(transform.position.x, transform.position.y, posicaoDeParticula.position.z);
        Instantiate(particulaDePouso);
        //Destruir o personagem
        Destroy (gameObject, 0.1f);
    }
    #endregion
