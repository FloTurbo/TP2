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
        //départ du chronomètre
        tempsActuel = tempsDepart;
        compteARebours.text = tempsActuel.ToString("0");

        //initialisation du champ de text gemeOver
        gameOver.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        //enlève 1 seconde
        tempsActuel -= 1 * Time.deltaTime;
        compteARebours.text = "Temps restant: " + tempsActuel.ToString("0"); /* affiche le nouveau temps */

        //vérifie si il arrive au bout du tempos apparti
        if (tempsActuel <= 0)
        {
            tempsActuel = 0;
            //afiche le message de game over
            gameOver.text = "Game Over";

            //appel de la scène d'acceuil après 1 seconde
            Invoke("changementSceneAcceuil", 1.0f);

            //désactive les contrôles du personnage
            personnage.enabled = false;

            
        }

        //si l'objectfif de capsules détuite est atteint
        if (capsules_nefaste.scores == capsules_nefaste.objectif)
        {
            //affichage du message de réussite
            gameOver.text = "Félicitation vous avec RÉUSSI!!!";

            //appel de la scène d'acceuil après 1 seconde
            Invoke("changementSceneAcceuil", 2.0f);

            tempsActuel = tempsDepart;
        }

        //afficahge du scores
        scores.text = capsules_nefaste.scores + " capsules détruites sur "+ capsules_nefaste.objectif;
    }

    void changementSceneAcceuil()
    {
        //appel de la scène d'acceuil
        SceneManager.LoadScene("ecran_acceuil");
    }
}
