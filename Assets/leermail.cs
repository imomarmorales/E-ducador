using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class leermail : MonoBehaviour
{
    // Start is called before the first frame updateprivate string input;

    private string input;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("playermail","");
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void leercadena(string S){
        input = S;
     PlayerPrefs.SetString("playermail",S);
    Debug.Log(S);
    }
}
