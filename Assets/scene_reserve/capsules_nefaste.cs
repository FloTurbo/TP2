using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsules_nefaste : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject capsule;
    public GameObject joueur;
    public GameObject explosion;
    public static int scores = 0; /* variable qui d�tient le score de joueur */

    void Start()
    {
        //instancie la variable de joueur au nom de arthur
        joueur = GameObject.Find("Arthur");
    }

    // Update is called once per frame
    void Update()
    {
        if (getDistance() < 0.9f) /* si les objets entre en contact */
        {
            //explostion de la capsule 
            Instantiate(explosion, transform.position, Quaternion.identity);

            //incr�mentation du score
            scores++;

            //d�truire la capsule
            Destroy(gameObject);
        }

    }


    private float getDistance() /* retourne la distance entre la capsule et le joueur */
    {
        return Vector3.Distance(transform.position, joueur.transform.position);
    }

}
