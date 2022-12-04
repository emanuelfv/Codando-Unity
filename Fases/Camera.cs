using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joog : MonoBehaviour
{
public Transform camera;

//Para uma câmera que segue o personagem com movimentos na horizontal, usaremos o seguinte código:
void Camera()
  {
      camera.position = new Vector3(transform.position.x, camera.position.y, camera.position.z);
  }
//Para uma câmera que segue o personagem com movimentos na horizontal, usaremos o seguinte código:
void Camera()
  {
      camera.position = new Vector3(transform.position.x, transform.position.y, camera.position.z);
  }
//Não esqueça de chamá-las no método Update
}
