using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Security.Cryptography.X509Certificates;

public class charger_sceneLaby : MonoBehaviour
{
        //m�thode pour changer de sc�ne
        public void changerScene()
        {
            //appel la sc�ne d�sir�e
            SceneManager.LoadScene("scene_laby");

        }
   

   
}
