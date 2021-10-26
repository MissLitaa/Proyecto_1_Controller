using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    //Velocidad de movimiento
    private float speed = 25;
    //Velocidad de giro
    private float turnSpeed = 30;

    //Ejes
    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        //Recoge en horizontal Input el eje horizontal. Edit>Project settings.
        horizontalInput = Input.GetAxis("Horizontal");
        //Recoge en vertical Input el eje vertical. Edit>Project settings.
        verticalInput = Input.GetAxis("Vertical");

        /*
        Translación. espacio = velocidad * tiempo. DeltaTime: tiempo entre frames.
        Le sumamos la multiplicación vertical para que al no puslar las flechas, se quede en 0
        */
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //Movimiento lateral manual. Si no pulsamos no se moverá lateralmente por que si pulsamos es uno, pero si no es 0 y 0x0=0.
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        //Rotación: rotar, vector 3.dirección, la velocidad, y el eje.
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
