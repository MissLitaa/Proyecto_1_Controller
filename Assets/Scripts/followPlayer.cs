using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -10);

        /*
        Late update: es llamado a cada frame pero es el �ltimo en actualizarse. Las c�maras se ponen en Late por que por ejemplo ense�a lo que
        ya ha pasado en Update 
        */
       
    void LateUpdate()
    {
        /*
        Accede a la posici�n de la c�mara en el primer paso, 
        igual a la posici�n del GameObject player (hemos arrastrado el gameobject player a la casilla del script.
        Sumamos la variable del offset
        */

        transform.position = player.transform.position + offset;
    }
}
