//Declarações
    //Jogador
    public Transform jogadorPosition;
    public Rigidbody gravidadeDoPlayer;
    public float velocidadeDoJogador;

    //Camera
    public Transform cameraPosition;
    public Camera cameraVision;
    public float velocidadeDaCamera, fOV;

//Métodos
    void CameraObj()
    {
        //Rotação da camera
        cameraPosition.eulerAngles += new Vector3(0, Input.GetAxisRaw("Camera") * velocidadeDaCamera, 0);
        
        //Posição da camera
        cameraPosition.position = new Vector3(jogadorPosition.position.x, jogadorPosition.position.y, jogadorPosition.position.z);
        
        //Campo de visão
        fOV -= Input.GetAxisRaw("CameraFOV");
        if(fOV > 50) fOV = 50;
        if(fOV < 20) fOV = 20;
        
        Camera.main.fieldOfView = fOV;
    }

    void Movimento()
    {
        if(Input.GetAxisRaw("Vertical") != 0)
        {
            gravidadeDoPlayer.velocity = cameraPosition.forward * Input.GetAxisRaw("Vertical") * velocidadeDoJogador;
        }
        if(Input.GetAxisRaw("Horizontal") != 0)
        {
            gravidadeDoPlayer.velocity = cameraPosition.right * Input.GetAxisRaw("Horizontal") * velocidadeDoJogador;
        }
        
        jogadorPosition.eulerAngles += new Vector3(0, Input.GetAxisRaw("Camera") * velocidadeDaCamera, 0);
    }
