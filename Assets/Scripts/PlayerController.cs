using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static int life = 100;
    private float speed = 3;
    private float rotateSpeed = 1.5f;
    void Start()
    {
        DispararEventos.onPlayerTeleport += OnPlayerTeleportHandler;
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, y) * speed * Time.deltaTime);
        transform.Rotate(new Vector3(0, x, 0) * rotateSpeed);
    }

    private void OnPlayerTeleportHandler()
    {
        transform.position = new Vector3(4.225f, 0.4f, -4.45f);
        Debug.Log("Player se suscribe al evento 'Player Teleport'");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Teleport"))
        {
            DispararEventos.onPlayerTeleport();
            Debug.Log("Player llama al evento 'Player Teleport'");
        }
    }
}
