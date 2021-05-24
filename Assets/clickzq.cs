using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class clickzq : MonoBehaviour
{
    public TextMeshProUGUI Texto;
    // Start is called before the first frame update
   public void clickizq(){
       Texto = GetComponent<TextMeshProUGUI>();

       
        Texto.SetText("Click Izquierdo: Permite la selección y la interacción con los programas.");
        Debug.Log("xd");
   }
}
