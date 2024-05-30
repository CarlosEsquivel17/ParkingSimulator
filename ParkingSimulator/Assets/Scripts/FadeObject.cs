using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeObject : MonoBehaviour
{

    public GameObject[] objetos; // Asigna los GameObjects aquí
    private Material[] materiales;
    private bool esVisible = true;

    // Start is called before the first frame update
    void Start()
    {
         // Inicializa el array de materiales
        materiales = new Material[objetos.Length];

        // Obtiene los materiales de los objetos
        for (int i = 0; i < objetos.Length; i++)
        {
            materiales[i] = objetos[i].GetComponent<Renderer>().material;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        // Cambia el estado de visibilidad de la flecha
        esVisible = !esVisible;
        

        for (int i = 0; i < objetos.Length; i++)
        {
            // Obtiene la transparencia actual
            float transparenciaActual = materiales[i].color.a;

            // Calcula la transparencia objetivo
            float transparenciaObjetivo = esVisible ? 1f : 0f;

            // Interpola entre la transparencia actual y la objetivo
            float transparenciaNueva = Mathf.Lerp(transparenciaActual, transparenciaObjetivo, Time.deltaTime);

            // Aplica la nueva transparencia al material del objeto
            Color color = materiales[i].color;
            color.a = transparenciaNueva;
            materiales[i].color = color;
        }
    
    }
}
