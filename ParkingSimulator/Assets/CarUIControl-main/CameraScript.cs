using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public Transform target;  // Referencia al objeto que la cámara seguirá (el carro).
    public float distance = 5.0f;  // Distancia desde el carro.
    public float height = 2.0f;    // Altura de la cámara sobre el carro.
    public float rotationDamping = 3.0f;  // Suavizado de rotación de la cámara.
    
    // Update is called once per frame
    void LateUpdate()
    {
        if (!target)
            return;

        // Calcula la posición deseada de la cámara.
        float wantedRotationAngle = target.eulerAngles.y;
        float wantedHeight = target.position.y + height;

        float currentRotationAngle = transform.eulerAngles.y;
        float currentHeight = transform.position.y;

        // Suaviza la rotación de la cámara.
        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

        // Calcula la nueva posición de la cámara.
        var currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);
        transform.position = target.position - currentRotation * Vector3.forward * distance;

        // Mantiene la altura deseada.
        transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

        // Hace que la cámara mire al objetivo.
        transform.LookAt(target);
    }
}