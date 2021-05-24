using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class change : MonoBehaviour
{
    // Start is called before the first frame update
    public string nombre;
   public void PlayGame()
    {   
        Debug.Log("click");
         SceneManager.LoadScene(nombre.ToString());
 
    }

}
