using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimeNow : MonoBehaviour
{
    public Transform hour;
    public Transform minute;
    public Transform second;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Transform hora = transform;
        int hora=System.DateTime.Now.Hour;
        int minuto=System.DateTime.Now.Minute;
        int segundo=System.DateTime.Now.Second;
        hour.Rotate(hora*30 * Time.deltaTime, 0, 0);
        minute.Rotate(minuto*30 * Time.deltaTime, 0, 0);
        second.Rotate(segundo*30*Time.deltaTime, 0, 0);
        Debug.Log("Hora: " + System.DateTime.Now.Hour);
        //transform.rotation = Quaternion.Euler(hora*30f, 0f, 0f);
        
       
    }
}