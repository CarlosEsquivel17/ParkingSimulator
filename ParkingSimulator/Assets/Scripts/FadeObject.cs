using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeObject : MonoBehaviour
{

    public GameObject objeto; 
    public GameObject player; 

    // Inicialización
    void Start()
    {
        InvokeRepeating("Toggle", 0, 1);
    }

    void Toggle()
    {
        // Cambia el estado de activación del GameObject
        objeto.SetActive(!objeto.activeSelf);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            CancelInvoke("Toggle");
            objeto.SetActive(false);
        }
    }
}
