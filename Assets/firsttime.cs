using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class firsttime : MonoBehaviour
{

    string frase = "¡Hola! Bienvenido a E-ducador. Mi nombre es Ernesto, seré tu guía a tráves de las lecciones.";
    string frase2 = "Antes de empezar necesito saber dos cosas muy importantes. ¿me ayudas?";
    public Text texto;
    public GameObject imagen;
    
    new public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(Reloj());
        
        PlayerPrefs.SetInt("ajustes",0);
        Debug.Log(PlayerPrefs.GetInt("ajustes"));
    }

    IEnumerator Reloj()
    {   
        
        foreach (char caracter in frase)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.1f);
        }
        audio.Pause();
        yield return new WaitForSeconds(6f);
        audio.UnPause();
        texto.text = "";
        foreach (char caracter in frase2)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.1f);
            
        }
        yield return new WaitForSeconds(3f);
        PlayerPrefs.SetInt("ajustes",1);
        Debug.Log(PlayerPrefs.GetInt("ajustes"));
        audio.Pause();
        
    }
}

