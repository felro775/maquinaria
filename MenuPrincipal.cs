using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public string EscenaItem1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Item1()
    {
        SceneManager.LoadScene(EscenaItem1);
    }

    public void Item2()
    {
        
    }

    public void Item3()
    {
        
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo...");
    }
}
