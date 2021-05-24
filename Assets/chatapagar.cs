using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chatapagar : MonoBehaviour
{
    // Start is called before the first frame update  // Start is called before the first frame update
    string frase = "Presiona el botón de encendido para prender el CPU y el Monitor.";
    string frase2 = "Presiona la pantalla para ir al menú de inicio de sesión.";
    string frase3 = "Introduce la contraseña correcta, es: ernesto123 no se la digas a nadie.";
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
