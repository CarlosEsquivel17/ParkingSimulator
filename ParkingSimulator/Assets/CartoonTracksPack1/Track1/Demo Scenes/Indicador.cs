using UnityEngine;

public class Indicador : MonoBehaviour
{
    public Transform coche; 
    public Transform indicador; 
    public Vector3 offset = new Vector3(0, 2, 0); 

    void Update()
    {
        
        if (indicador == null)
        {
            indicador = transform.Find("Lamborghini_Aventador_P1"); 
        }

        // posición del indicador 
        indicador.position = coche.position + offset;
    }
}



