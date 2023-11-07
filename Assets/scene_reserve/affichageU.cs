using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.ThirdPerson;

public class affichageU : MonoBehaviour
{
    // Start is called before the first frame update
    public float tempsActuel = 0f;
    public float tempsDepart = 90f;
    public TextMeshProUGUI compteARebours;
    public TextMeshProUGUI gameOver;
    public TextMeshProUGUI scores;
    public ThirdPersonCharacter personnage;
    void Start()
    {
        //d�part du chronom�tre
        tempsActuel = tempsDepart;
        compteARebours.text = tempsActuel.ToString("0");

        //initialisation du champ de text gemeOver
        gameOver.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        //enl�ve 1 seconde
        tempsActuel -= 1 * Time.deltaTime;
        compteARebours.text = "Temps restant: " + tempsActuel.ToString("0"); /* affiche le nouveau temps */

        //v�rifie si il arrive au bout du tempos apparti
        if (tempsActuel <= 0)
        {
            tempsActuel = 0;
            //afiche le message de game over
            gameOver.text = "Game Over";

            //appel de la sc�ne d'acceuil apr�s 1 seconde
            Invoke("changementSceneAcceuil", 1.0f);

            //d�sactive les contr�les du personnage
            personnage.enabled = false;

            
        }

        //si l'objectfif de capsules d�tuite est atteint
        if (capsules_nefaste.scores == capsules_nefaste.objectif)
        {
            //affichage du message de r�ussite
            gameOver.text = "F�licitation vous avec R�USSI!!!";

            //appel de la sc�ne d'acceuil apr�s 1 seconde
            Invoke("changementSceneAcceuil", 2.0f);

            tempsActuel = tempsDepart;
        }

        //afficahge du scores
        scores.text = capsules_nefaste.scores + " capsules d�truites sur "+ capsules_nefaste.objectif;
    }

    void changementSceneAcceuil()
    {
        //appel de la sc�ne d'acceuil
        SceneManager.LoadScene("ecran_acceuil");
    }
}
