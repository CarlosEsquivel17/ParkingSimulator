using UnityEngine;
using UnityEngine.UI;

public class Colision : MonoBehaviour
{
    public GameObject panelAdvertencia;
    public Button botonContinuar; 

    private void OnCollisionEnter(Collision collision)
    {
      
        if (collision.gameObject.CompareTag("Barrera"))
        { 
            panelAdvertencia.SetActive(true);
            botonContinuar.interactable = false;
            Invoke("RestablecerJuego", 5f);
        }
    }

    public void RestablecerJuego()
    {
        
        panelAdvertencia.SetActive(false);
        botonContinuar.interactable = true;
    }
} 