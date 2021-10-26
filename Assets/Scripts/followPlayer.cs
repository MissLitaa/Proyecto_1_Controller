using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -10);

        /*
        Late update: es llamado a cada frame pero es el último en actualizarse. Las cámaras se ponen en Late por que por ejemplo enseña lo que
        ya ha pasado en Update 
        */
       
    void LateUpdate()
    {
        /*
        Accede a la posición de la cámara en el primer paso, 
        igual a la posición del GameObject player (hemos arrastrado el gameobject player a la casilla del script.
        Sumamos la variable del offset
        */

        transform.position = player.transform.position + offset;
    }
}
