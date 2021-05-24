using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leccion0text : MonoBehaviour
{
    // Start is called before the first frame update
    string frase = "Algunas lecciones vendrán en formato de videos cortos.";
    string frase2 = "Sube el volumen y pon atención para contestar las siguientes actividades.";
    string frase3 = "Presiona la flecha azul para continuar a la siguiente actividad.";
    public Text texto;
  
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Reloj());
     
    }

    IEnumerator Reloj()
    {
        foreach (char caracter in frase)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.1f);
        }
         yield return new WaitForSeconds(3f);
        texto.text="";
         foreach (char caracter in frase2)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.1f);
        }
           yield return new WaitForSeconds(3f);
        texto.text="";
         foreach (char caracter in frase3)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.1f);
        }
        
    }
}
