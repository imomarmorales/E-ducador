using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pruebas : MonoBehaviour
{ 
  //GameObject flecha;
    public Image cross;
    public AudioSource correcto;
    public Image palomita;
    public Image cpu;
    public Image monitor;
    public GameObject boton1;
    public GameObject boton2;
    
    public GameObject fondo;
    public Image trofeo;
    
    public InputField contra;
    public Text lolograste;
    GameObject pass;
    GameObject entrar;
    
    public AudioSource incorrecto;
    private string input;
    // Start is called before the first frame update  // Start is called before the first frame update
    private int cont=0;
    void Start(){
        PlayerPrefs.GetInt("contador",0);
        pass=GameObject.Find("contrasena");
        entrar=GameObject.Find("entrar");
        //entrar=GameObject.Find("flecha");
      pass.SetActive(false);
      entrar.SetActive(false);
     // flecha.SetActive(false);
    monitor.enabled=false;
    palomita.enabled=false;
    boton2.SetActive(false);
    fondo.SetActive(false);
    trofeo.enabled=false;
    lolograste.enabled=false;
    cross.enabled=false;
   
       
        
        
    }
    public void cpuboton()
    {   
        Debug.Log("aaa");
         Destroy(cpu.gameObject);
        Destroy(boton1.gameObject);
        monitor.enabled=true;
        boton2.SetActive(true);
        palomita.enabled=true;
        correcto.Play();
        cont++;
        Debug.Log(cont);
        
    }
   public void monitorboton(){
       
        Destroy(boton2.gameObject);
        correcto.Play(0);
        cont++;
        fondo.SetActive(true);
        Debug.Log(cont);
    }
      public void fondoboton(){
          
        correcto.Play(0);
      entrar.SetActive(true);
       pass.SetActive(true);
       cont++;
       Debug.Log(cont);
      
    }
    public void entrarboton(string s)
    {
        
        Debug.Log(s);   
        if(contra.text=="ernesto123"){
            correcto.Play(0);
            cross.enabled=false;
            palomita.enabled=true;
            Destroy(monitor.gameObject);
            Destroy(fondo.gameObject);
            Destroy(entrar.gameObject);
            Destroy(pass.gameObject);
            lolograste.enabled=true;
            trofeo.enabled=true;
            cont++;
            Debug.Log(cont);
            PlayerPrefs.SetInt("contador",cont);
            //flecha.SetActive(true);

        }
        else{
           incorrecto.Play(0);
           cross.enabled=true;
           palomita.enabled=false;
        }
}}