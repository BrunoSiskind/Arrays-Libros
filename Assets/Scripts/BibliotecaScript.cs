using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BibliotecaScript : MonoBehaviour
{
    public LibroScript[] libros;
    public GameObject cartelReservado;

    // Start is called before the first frame update
    void Start()
    {
        libros = FindObjectsOfType<LibroScript>();
         for(int i = 0; i < libros.Length; i++)
         {
            libros[i].color = Random.Range(1,6);
         }  
    }

    void ReservarLibro(int index)
    {
        if(!libros[index].reservado)
        {
            libros[index] = true;
            libros[index].color = 0;
        }
        else
        {
            MostrarMensajeReservado();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (libros[0].reservado)
            {
                ReservarLibro(0);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
             if (libros[1].reservado)
            {
                ReservarLibro(1);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
             if (libros[2].reservado)
            {
                ReservarLibro(2);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
             if (libros[3].reservado)
            {
                ReservarLibro(3);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
             if (libros[4].reservado)
            {
                ReservarLibro(4);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
             if (libros[5].reservado)
            {
                ReservarLibro(5);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
             if (libros[6].reservado)
            {
                ReservarLibro(6);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
             if (libros[7].reservado)
            {
                ReservarLibro(7);
            }
        }
    }

    void MostrarMensajeReservado()
    {
        cartelReservado.SetActive(true);
        Invoke(nameof(OcultarMensajeReservado),2);
    }

    void OcultarMensajeReservado()
    {
        cartelReservado.SetActive(false);
    }
}
