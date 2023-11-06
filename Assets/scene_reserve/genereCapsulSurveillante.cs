using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
//using System.Security.Policy;
using UnityEngine;

public class genereCapsulSurveillante : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject capsuleEnnemie;
    public GameObject capsuleSurveilante;


    void Start()
    {
        //boucle qui appelle la m�thode qui g�n�reles capsules
        for(int i = 0; i < 205; i++) 
        {
            instancierCapsule(capsuleEnnemie);
            instancierCapsule(capsuleSurveilante);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void instancierCapsule(GameObject objet)
    {
        //random la coordonn�e (x,z)
        float x = UnityEngine.Random.Range(-140f, 140f);
        float z = UnityEngine.Random.Range(-140, 50);

        Terrain terrain = Terrain.activeTerrain; //r�f�rence du terrain 
        Vector3 positionObjet = new Vector3(x, 0, z); //posistion de l'objet instancier
        float hauteurTerrain = terrain.SampleHeight(positionObjet); //retroune la hauteur du terrain � la position

        // variable pour la position
        Vector3 pos = new Vector3(x, hauteurTerrain+0.4f, z);
        Instantiate(objet, pos, Quaternion.identity);
    }
}
