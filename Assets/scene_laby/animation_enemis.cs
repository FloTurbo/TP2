using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_enemis : MonoBehaviour
{
    // Start is called before the first frame update
    public float vitesse = 1f; /* vitesse des monstres */
    public GameObject[] points;
   
    int indexActuel = 0;

    ////méthode getDistance
    //private float getDistance()
    //{
    //    return Vector3.Distance(transform.position, points[indexActuel].transform.position);
    //}

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, points[indexActuel].transform.position) < 0.1f)
        {
            // Incrémentation de l'index et régule sa valeur en fonction du nombre de points présents
            indexActuel = (indexActuel + 1) % points.Length;
        }

        //déplace l'objet
        transform.position = Vector3.MoveTowards(transform.position, points[indexActuel].transform.position, vitesse * Time.deltaTime);
    }
}
