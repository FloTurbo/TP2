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
    public float tempsDepart = 60f;
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

            //appel de la sc�ne d'acceuil
            SceneManager.LoadScene("ecran_acceuil");

            //d�sactive les contr�les du personnage
            personnage.enabled = false;
        }

        //afficahge du scores
        scores.text = capsules_nefaste.scores + " capsules d�truites";
    }
}
