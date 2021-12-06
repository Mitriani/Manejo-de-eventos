using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class PuertaController : MonoBehaviour
{
    void Start()
    {
        DispararEventos.onAbrirPuerta += OnAbrirPuertaHandler;
        DispararEventos.onCerrarPuerta += OnCerrarPuertaHandler;
    }

    private void OnAbrirPuertaHandler()
    {
        transform.position = new Vector3(0.725f, 1.5f, -0.021f);
        Debug.Log("Puerta se suscribe al evento 'Abrir Puerta'");
    }
    private void OnCerrarPuertaHandler()
    {
        transform.position = new Vector3(0.725f, 0.5f, -0.021f);
        Debug.Log("Puerta se suscribe al evento 'Cerrar Puerta'");

    }
}