using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class leernombre : MonoBehaviour

{
public InputField nombre;
public InputField mail;
public InputField edad;
public GameObject boton;
    public Text leyenda;
    
 
   
    // Start is called before the first frame update
   
   

  public void PlayGame()
    {   
        PlayerPrefs.SetInt("VMail",0);
        Debug.Log("click");
        PlayerPrefs.SetString("playername",nombre.text);
         Debug.Log(nombre.text);
         PlayerPrefs.SetString("playermail",mail.text);
         Debug.Log(mail.text);
         PlayerPrefs.SetString("playeredad",edad.text);
         Debug.Log(edad.text);
         PlayerPrefs.SetInt("SaveSettings",1);
         edad.enabled=false;
        
         if (mail.text.IndexOf('@') <= 0)
{
    leyenda.text="Formato de Email Incorrecto.";
    leyenda.color=Color.red;
}
else{
   leyenda.text="Tus datos se han guardado.";
    leyenda.color=Color.green;
}
 
        
        

}
    }
