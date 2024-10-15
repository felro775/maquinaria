using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MenuItemM1 : MonoBehaviour
{
    public GameObject Tabc;
    public UnityEngine.UI.Button btnMenuPrinc;
    public UnityEngine.UI.Button btnMostrarLayout;
    public UnityEngine.UI.Button btnMostrarOpciones;
    public UnityEngine.UI.Button btnCalcular;

    public TMPro.TMP_InputField inpField_02;
    public TMPro.TMP_InputField inpField_03;
    public TMPro.TMP_InputField inpField_04;
    public TMPro.TMP_InputField inpField_05;
    public TMPro.TMP_InputField inpField_06;
    public TMPro.TMP_InputField inpField_07;
    public TMPro.TMP_InputField inpField_08;
    public TMPro.TMP_InputField inpField_09;
    public TMPro.TMP_InputField inpField_10;
    public TMPro.TMP_InputField inpField_11;
    public TMPro.TMP_InputField inpField_12;
    public TMPro.TMP_InputField inpField_13;

    public double tc, td, tf;
    public double tv, D, vc, vd;
    public double Cm, R, Q, E, F;

    // Start is called before the first frame update
    void Start()
    {
        btnMenuPrinc.onClick.AddListener(Salir);
        btnMostrarLayout.onClick.AddListener(mostrarLayouts);
        btnMostrarOpciones.onClick.AddListener(mostrarOpciones);
        btnCalcular.onClick.AddListener(Calcular);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Tabc.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            Tabc.SetActive(true);
        }
    }

    public void mostrarLayouts()
    {
        Tabc.SetActive(false);
    }
    public void mostrarOpciones()
    {
        Tabc.SetActive(true);
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo...");
    }

    public void Calcular()
    {
        tc = Convert.ToDouble(inpField_08.text);
        td = Convert.ToDouble(inpField_09.text);
        tf = tc + td;
        inpField_10.text = Convert.ToString(tf);

        D = Convert.ToDouble(inpField_04.text);
        vc = Convert.ToDouble(inpField_06.text);
        vd = Convert.ToDouble(inpField_07.text);
        tv = (D*60/vc)+(D*60/vd);
        inpField_11.text = Convert.ToString(tv);

        Cm = tf + tv;
        inpField_12.text = Convert.ToString(Cm);

        Q = Convert.ToDouble(inpField_03.text);
        E = Convert.ToDouble(inpField_02.text);
        F = Convert.ToDouble(inpField_05.text);
        R = (Q * E *60)/(Cm * F);
        inpField_13.text = Convert.ToString(Math.Round(R,2));
    }
}
