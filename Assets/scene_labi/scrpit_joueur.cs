using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpit_joueur : MonoBehaviour
{
    // Start is called before the first frame update
    // variables du programme
    private bool possedeClef = false;
    public GameObject porte;
    Animator animationPorte;
    public GameObject clefSurJoueur;

    private void Start()
    {
        //instancie l'animation � pcartir de celle recherch�e
       animationPorte = porte.GetComponent<Animator>();
       //animationPorte.enabled = false;
    }

    //si il y a collision avec l'objet qui parte le scripte
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "tagClef")  // si l'objet en collision est tagger comme �tant une cl�
        {
            possedeClef=true; /* variable bool�en � true */

            Destroy(other.gameObject); /* d�truit l'objet qui cr�e la collision */
            clefSurJoueur.SetActive(true);
        }

        if(other.gameObject.tag == "porte")
        {
            //si le personnage poss�de la clef
            if(possedeClef == true)
            {
                //part l'animation
                animationPorte.enabled = true;
            }
           
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
