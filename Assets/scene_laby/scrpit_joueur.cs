using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.ThirdPerson;
using Unity.VisualScripting;


public class scrpit_joueur : MonoBehaviour
{
    // Start is called before the first frame update
    // variables du programme
    private bool possedeClef = false;
    public GameObject porte;
    public GameObject clefSurJoueur;
    public ThirdPersonCharacter personnage;
    Animator animationPorte;
    public TextMeshProUGUI gameOver;

    private void Start()
    {
        //instancie l'animation � pcartir de celle recherch�e
        animationPorte = porte.GetComponent<Animator>();
        

        //initialisation du champ de text gemeOver
        gameOver.text = "";
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

        if(other.gameObject.tag == "ennemi") /* si le joueur entre en contact avec un ennemi*/
        {
            //d�sactive les contr�les du personnage
            personnage.enabled = false;

            //affiche le message de game over
            gameOver.text = "Game Over";

            //appel de la sc�ne d'acceuil
            SceneManager.LoadScene("ecran_acceuil");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
