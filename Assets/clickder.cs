using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class clickder : MonoBehaviour
{
    public TextMeshProUGUI Texto;
    // Start is called before the first frame update
   public void clickider(){
       Texto = GetComponent<TextMeshProUGUI>();

       
        Texto.SetText("Click Derecho: se usa a menudo para abrir menús contextuales, que son menús emergentes que cambian según dónde haga clic");
        Debug.Log("xd");
   }
}
