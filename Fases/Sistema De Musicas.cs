using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeMusicas : MonoBehaviour
{
    //Onde pôr as músicas
    public AudioSource procurarMusicasDeFundo;
    //Quantas músicas pôr
    public AudioClip[] musicasDeFundo;
    void Start()
    {
        //A cada quantidade de músicas, uma música é colocada
        AudioClip musicasDeFundoDessaFase = musicasDeFundo[0];
        //Definir que a música tocada será a da fase
        procurarMusicasDeFundo.clip = musicasDeFundoDessaFase;
        //Tocar a música
        procurarMusicasDeFundo.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
