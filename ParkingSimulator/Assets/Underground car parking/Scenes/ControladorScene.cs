using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void CambiarEscena(string nombre) {
        
            SceneManager.LoadScene(nombre);
    }

    public void StopSound(bool bandera){
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        if(bandera==true){
            foreach (AudioSource a in audios){
                a.Pause();
            }
        }else{
            foreach (AudioSource a in audios){
                a.Play();
            }
        }

    }

}
