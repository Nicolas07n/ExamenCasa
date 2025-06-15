using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class MovingWall : MonoBehaviour
{
    public float speed= 2f;
    private Vector2 direction = Vector2.right;
    public AudioClip sonidoCambioDireccion;

    void Start()
    {
        StartCoroutine(MoveWall()); 
    }

    IEnumerator MoveWall()
    {
        while (true)
        {
            GetComponent<Rigidbody2D>().velocity = direction * speed;
            yield return new WaitForSeconds(3f);
            direction *= -1;
            if (GameManager.instance != null)
            {
                { GameManager.instance.RegistrarCambioDireccion(); }

            }

            if(sonidoCambioDireccion != null && AudioManager.instance != null)
            {
                AudioManager.instance.PlayAudio(sonidoCambioDireccion, "Cambia de Dirreccion");


            }
        }


    }



}
