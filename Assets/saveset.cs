using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class saveset : MonoBehaviour
{
    // Start is called before the first frame update
  
    public GameObject boton;
    public Text leyenda;
    void Start()
    {
                PlayerPrefs.SetInt("VMail",0);

    Debug.Log(PlayerPrefs.GetInt("VMail"));
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("VMail")>0)
{
    boton.SetActive(true);
    if(PlayerPrefs.GetInt("VMail")==2){

    
    leyenda.text="Formato de Email Incorrecto.";
    leyenda.color=Color.red;
    }
    if(PlayerPrefs.GetInt("VMail")==1){

    
    leyenda.text="Tus datos se han guardado.";
    leyenda.color=Color.green;
}
else
{
    boton.SetActive(false);
}
    }
}
}