using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TakeDamage : MonoBehaviour
{
    [SerializeField] private UnityEvent onDamage;

    void Start()
    {
        if (onDamage == null)
        {
            onDamage = new UnityEvent();
        }
        onDamage.AddListener(OnDamageHandler);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && onDamage != null)
        {
            onDamage.Invoke();
        }
    }

    public void OnDamageHandler()
    {
        Debug.Log("Taking Damage");
        PlayerController.life -= 10;
        if (PlayerController.life <= 0)
        {
            PlayerController.life = 1; 
            Debug.Log("**** NO PODÉS MORIR! ****");

        }
        Debug.Log("VIDA: " + PlayerController.life);
    }
}