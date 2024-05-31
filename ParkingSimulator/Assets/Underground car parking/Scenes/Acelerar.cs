using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class Acelerar : MonoBehaviour
{
    public InputActionProperty moveForwardAction;
    public float speed = 5f;
    private bool isMoving = false;

    void OnEnable()
    {
        moveForwardAction.action.performed += OnMoveForward;
        moveForwardAction.action.canceled += OnStopMoving;
        Debug.Log("Si te mueves");
    }

    void OnDisable()
    {
        moveForwardAction.action.performed -= OnMoveForward;
        moveForwardAction.action.canceled -= OnStopMoving;
    }

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    private void OnMoveForward(InputAction.CallbackContext context)
    {
        isMoving = true;
    }

    private void OnStopMoving(InputAction.CallbackContext context)
    {
        isMoving = false;
    }
}

