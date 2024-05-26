using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  


public class TutorialManager : MonoBehaviour
{
    public GameObject[] tutorialPanels; // Array to hold tutorial panels
    private int currentPanelIndex = 0;

    void Start()
    {
        ShowPanel(0);
    }

    public void ShowPanel(int indice)
    {
        for (int i = 0; i < tutorialPanels.Length; i++)
        {
            tutorialPanels[i].SetActive(i == indice);
        }
        currentPanelIndex =indice;
    }

    public void NextPanel()
    {
        if (currentPanelIndex < tutorialPanels.Length - 1)
        {
            ShowPanel(currentPanelIndex + 1);
        }
    }
}



