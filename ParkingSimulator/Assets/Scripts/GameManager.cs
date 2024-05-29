using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject notificationText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        DisableTextOnKeyPress(KeyCode.E);
    }

    private void DisableTextOnKeyPress(KeyCode key) {

        if (Input.GetKeyDown(key) && notificationText != null) {
            notificationText.SetActive(false);
        }
    }
}
