using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_enemis : MonoBehaviour
{
    // Start is called before the first frame update
    public float vitesse = 1f; /* vitesse des monstres */
    public GameObject[] points;
   
    int indexActuel = 0;

    ////m�thode getDistance
    //private float getDistance()
    //{
    //    return Vector3.Distance(transform.position, points[indexActuel].transform.position);
    //}

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, points[indexActuel].transform.position) < 0.1f)
        {
            // Incr�mentation de l'index et r�gule sa valeur en fonction du nombre de points pr�sents
            indexActuel = (indexActuel + 1) % points.Length;
        }

        //d�place l'objet
        transform.position = Vector3.MoveTowards(transform.position, points[indexActuel].transform.position, vitesse * Time.deltaTime);
    }
}
