  #region Efeitos sonoros
    //Sisitema de som
    public AudioSource rodarEfeitos;
    //Quantas músicas pôr
    public AudioClip[] efeitoSonoro;
    //Para rodar no código
    public int qualEfeito;
  #endregion

void EfeitosSonoro()
    {
        //A cada quantidade de músicas, uma música é colocada
        AudioClip efeitoSonoroAtual = efeitoSonoro[qualEfeito];
        //Definir que a música tocada será a da fase
        rodarEfeitos.clip = efeitoSonoroAtual;
        //Tocar a música
        rodarEfeitos.Play();
    }
