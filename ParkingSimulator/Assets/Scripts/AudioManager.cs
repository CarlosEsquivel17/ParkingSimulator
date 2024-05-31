using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    public GameObject suelo;
    public GameObject coche;
    public TextMeshProUGUI uiText;
    private int contadorColisiones = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {
        // Comprueba si el coche está colisionando con algo que no sea el suelo
        if (collision.gameObject != suelo)
        {
            // Incrementa el contador de colisiones
            contadorColisiones++;

            // Actualiza el texto de la UI para mostrar el nuevo contador
            uiText.text = "Colisiones: " + contadorColisiones;
            Debug.Log("Colisiones: " + contadorColisiones);
        }
    }
}
