using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TakeHeal : MonoBehaviour
{
    [SerializeField] private UnityEvent onHeal;

    void Start()
    {
        if (onHeal == null)
        {
            onHeal = new UnityEvent();
        }
        onHeal.AddListener(OnHealHandler);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && onHeal != null)
        {
            onHeal.Invoke();
        }
    }

    public void OnHealHandler()
    {
        Debug.Log("Healing");
        PlayerController.life += 10;
        if (PlayerController.life >= 100)
        {
            PlayerController.life = 100;
            Debug.Log("**** YA TENÉS LA VIDA AL MÁXIMO! ****");
        }
        Debug.Log("VIDA: " + PlayerController.life);
    }
}