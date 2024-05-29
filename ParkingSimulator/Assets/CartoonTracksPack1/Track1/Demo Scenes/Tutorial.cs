using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tutorial : MonoBehaviour
{
   


    public GameObject[] tutorialPanel; 
    private int ActualPanelIndex = 0;
     public Button nextButton; // Agregamos una referencia al botón "Next"

    void Start()
    {
        ShowPanel(0);
    }

    public void ShowPanel(int panelIndex)
    {
        for (int i = 0; i < tutorialPanel.Length; i++)
        {
            tutorialPanel[i].SetActive(i == panelIndex);
           // tutorialPanel[i-1].SetActive(false);
        }
        ActualPanelIndex = panelIndex; 
    }

    public void NextPanel()
    {
        if (ActualPanelIndex< tutorialPanel.Length - 1)
        {
            ShowPanel(ActualPanelIndex+ 1);

        }else{

         tutorialPanel[ActualPanelIndex].SetActive(false);
            nextButton.gameObject.SetActive(false);
        }
    }
}