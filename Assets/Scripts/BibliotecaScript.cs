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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {

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
