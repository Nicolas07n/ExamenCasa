using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int cambiosDireccion = 0;
    public int CambiosDireccion => cambiosDireccion;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
        public void RegistrarCambioDireccion()
        {
         cambiosDireccion++;    

        }
     




}
