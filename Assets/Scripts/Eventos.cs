using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class Eventos : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Green") && other.gameObject.CompareTag("Player"))
        {
            DispararEventos.onAbrirPuerta();
            Debug.Log("AbrirPuertaGreen llama al evento 'Abrir puerta'");
        }
        if (gameObject.CompareTag("Red") && other.gameObject.CompareTag("Player"))
        {
            Debug.Log("CerrarPuertaRed llama al evento 'Cerrar puerta'");
            DispararEventos.onCerrarPuerta();
        }
        if (gameObject.CompareTag("Purple") && other.gameObject.CompareTag("Player"))
        {
            Debug.Log("CerrarPuertaRed llama al evento 'Cerrar puerta'");
        }
    }
}

public static class DispararEventos
{
    public static Action onAbrirPuerta;
    public static Action onCerrarPuerta;
    public static Action onPlayerTeleport;
}
