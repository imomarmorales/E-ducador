using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawntime : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boton;
    public float segundos;
        void Start()
    {
        boton.SetActive(false);
    StartCoroutine(Timer());
    }

    // Update is called once per frame
  IEnumerator Timer()
    {
yield return new WaitForSeconds(segundos);
    boton.SetActive(true);
    }
}