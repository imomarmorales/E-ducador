using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aparecerflecha : MonoBehaviour
{
    // Start is called before the first frame update
    public int limit=0;
    public Image flecha;
    void Start()
    {
        flecha.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("contador")==limit){
            flecha.enabled=true;
        
        }
    }
}
