using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class botonazo : MonoBehaviour
{
    public AudioSource correcto;
    public Image palomita;
    public Image cpu;
    public Image monitor;
    public GameObject boton1;
    public GameObject boton2;
    public Button entrar;
    public Image fondo;
    public Image trofeo;
    
    public Text lolograste;
    public InputField pass;
    private string input;
    // Start is called before the first frame update  // Start is called before the first frame update

    void Start(){
        

        boton2.SetActive(false);

        entrar.enabled=false;

        trofeo.enabled=false;

        monitor.enabled=false;

        palomita.enabled=false;
        
        
        
        
        lolograste.enabled=false;

        fondo.enabled=false;

        pass.enabled=false;
        
        
    }
    public void cpuboton()
    {   
        Destroy(cpu.gameObject);
        Destroy(boton1.gameObject);
        monitor.enabled=true;
        boton2.SetActive(true);
        palomita.enabled=true;
        correcto.Play(0);
        
    }
    

}
