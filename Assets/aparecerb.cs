using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparecerb : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boton;
    void Start()
    {
    Debug.Log(PlayerPrefs.GetInt("ajustes"));
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("ajustes")>0)
{
    boton.SetActive(true);
}
else
{
    boton.SetActive(false);
}
    }
}