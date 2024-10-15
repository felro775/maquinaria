using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovVolqueta : MonoBehaviour
{
    public Transform posicionSiguiente;
    public int velocidadRotacion = 5;
    public int velocidadTraslacion = 10;
    public List<Transform> posicionBase;

    void Update()
    {
        //transform.Rotate(Vector3.forward, Time.deltaTime * velocidadRotacion);

        transform.Translate((posicionSiguiente.position - transform.position).normalized*Time.deltaTime
        *velocidadTraslacion,Space.World);
   
        if(Vector3.Distance(transform.position, posicionSiguiente.position) < 0.1f)
        {
            if(posicionBase.Count > posicionBase.IndexOf(posicionSiguiente)+ 1)
            {
                posicionSiguiente = posicionBase[posicionBase.IndexOf(posicionSiguiente)+ 1 ];
            }
            else
            {
                posicionSiguiente = posicionBase[0];
            }

        }
    }
}
