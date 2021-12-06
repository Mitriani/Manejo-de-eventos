using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LifeHud : MonoBehaviour
{
    [SerializeField] private UnityEvent onLifeHud;

    Text lifetext;

    void Start()
    {
        lifetext = GetComponent<Text>();

        if (onLifeHud == null)
        {
            onLifeHud = new UnityEvent();
        }
        onLifeHud.AddListener(OnLifeHudHandler);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && onLifeHud != null)
        {
            onLifeHud.Invoke();
        }

        lifetext.text = "VIDA: " + PlayerController.life;
    }

    public void OnLifeHudHandler()
    {
        Debug.Log("Cambio en el HUD");
    }
}