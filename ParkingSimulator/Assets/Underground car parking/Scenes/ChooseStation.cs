using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChooseStation : MonoBehaviour
{

    public GameObject[] cajonEstacionamiento;
    public GameObject cono;
    System.Random rdm;
    int eleccion;    // Start is called before the first frame update
    void Start()
    {
        System.Random rdm = new System.Random();
        eleccion = rdm.Next(cajonEstacionamiento.Length);
        CrearCubo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CrearCubo(){
        GameObject padreAleatorio = cajonEstacionamiento[eleccion];

        //GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cono.transform.SetParent(padreAleatorio.transform);

        cono.transform.localPosition = Vector3.zero;
        cono.transform.localScale = new Vector3(1, 1, 1);
    }
}
