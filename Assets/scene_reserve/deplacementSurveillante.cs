using System;
using System.Collections;
using System.Collections.Generic;
//using System.Collections.Specialized;
//using System.Security.Policy;
using UnityEngine;

public class deplacementSurveillante : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject joueur;
    public GameObject explosion;
    Color couleurDebut;
    private float dernierTempsExecution = 0;
    private float delaiMinimum = 2.0f; // Délai minimum en secondes

    void Start()
    {
        //instancie la variable de joueur au nom de arthur
        joueur = GameObject.Find("Arthur");

        //instancie la couleur initial à la couleur initiale de
        couleurDebut = GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        //vérifie si la distance en inférieur à 10cm
        if(getDistance() < 5f)
        {
            //modifie la couleur
            GetComponent<Renderer>().material.color = Color.red;
           
            //déplace la capsule
            transform.LookAt(joueur.transform.position); /* dirige la capsule vers le joueur */
            transform.Translate(Vector3.forward * Time.deltaTime * 1.2f); /* déplace la capsule */
        }
        if(getDistance() > 5f) /* si ils sont à plus de 10cm */
        {
            GetComponent<Renderer>().material.color = couleurDebut;

        }
        if(getDistance() < 0.9f) /* si les objets entre en contact */
        {
            
            //explostion de la capsule 
            Instantiate(explosion, transform.position, Quaternion.identity);

            //empêche la cqpsule d'Attaquer le personnage 2 fois de suite
            if (Time.time - dernierTempsExecution >= delaiMinimum)
            {
               
                //enlève 2 au score du joueur
                capsules_nefaste.scores = capsules_nefaste.scores - 2;

                //réinitialise le temps d'exécution
                dernierTempsExecution = Time.time;
            }

            

            //vérifie que le nombre ne soit pas négatif
            if(capsules_nefaste.scores < 0)
            {
                capsules_nefaste.scores = 0;
            }
        }


    }


    private float getDistance() /* retourne la distance entre la capsule et le joueur */
    {
        return Vector3.Distance(transform.position, joueur.transform.position);
    }
}
