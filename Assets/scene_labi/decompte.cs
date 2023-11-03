using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class decompte : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject joueur;
    public float tempsActuel = 0f;
    public float tempsDepart = 60f;
    public TextMeshProUGUI compteARebours;
    public TextMeshProUGUI gameOver;
    void Start()
    {
        //départ du chronomètre
        tempsActuel = tempsDepart;
        compteARebours.text =  tempsActuel.ToString("0");

        //initialisation du champ de text gemeOver
        gameOver.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        //enlève 1 seconde
        tempsActuel -= 1 * Time.deltaTime;
        compteARebours.text = "Temps restant: "+ tempsActuel.ToString("0"); /* affiche le nouveau temps */
        
        //vérifie si il arrive au bout du tempos apparti
        if(tempsActuel <= 0 )
        {
            tempsActuel = 0;
            //afiche le message de game over
            gameOver.text = "Game Over";

            //empêche le person de bouger
            //joueur.SetActive(false);
        }
    }
}
