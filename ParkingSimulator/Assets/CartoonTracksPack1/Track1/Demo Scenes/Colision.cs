using UnityEngine;
using UnityEngine.UI;

public class Colision : MonoBehaviour
{
    public GameObject collisionPanel;  
    public Button continueButton;     
    void Start()
    {  
        collisionPanel.SetActive(false);
         continueButton.gameObject.SetActive(false);
        continueButton.onClick.AddListener(ContinueButtonPressed);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisión con: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Barrera"))
        {        
            collisionPanel.SetActive(true);
            continueButton.gameObject.SetActive(true); 
            Time.timeScale = 0;
        }
    }

    void ContinueButtonPressed()
    {    
        collisionPanel.SetActive(false);
        continueButton.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
