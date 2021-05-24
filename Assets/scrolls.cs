using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class scrolls : MonoBehaviour
{
    // Start is called before the first frame update
     public TextMeshProUGUI Texto;
    public void scroll(){
    Texto = GetComponent<TextMeshProUGUI>();

       
        Texto.SetText("Scroll: En una ventana desplazable, girar la rueda hacia ti para moverse hacia abajo, y alejándose de ti para moverse hacia arriba.");
        Debug.Log("");
        
    }
}
