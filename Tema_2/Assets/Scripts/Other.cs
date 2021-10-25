using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Other : MonoBehaviour
{
    public Vector3 myPos;
    public string hello;

    // Start is called before the first frame update
    void Start()
    {

        HelloWorld();

        hello = GetHello();
        Debug.Log(hello);
        /*
        myPos = new Vector3(1,5,0);
        transform.position = myPos;
        Debug.Log(transform.position);
        */

        /*
        myPos = Vector3.up;
        transform.position = myPos; 
        Debug.Log(transform.position);
        */


    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += Vector3.down;
        }
        */

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
        }
        //Teclas asignadas para izquierda y derecha


        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position += Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position += Vector3.down;
        }
        //Teclas asignadas para arriba y abajo


        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.forward;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.back;
        }
        //Teclas asignadas para moverse adelante y atras


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation *= Quaternion.Euler(0, 10, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation *= Quaternion.Euler(0, -10, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.rotation *= Quaternion.Euler(10, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.rotation *= Quaternion.Euler(-10, 0, 0);
        }
        //Teclas asignadas para rotar

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.localScale += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            transform.localScale -= Vector3.right;
        }
    }

    public void HelloWorld()
    {
    Debug.Log("¡Hola Mundo!");
    }

    public string GetHello()
    {
        return "¡Hola!";
    }
}
