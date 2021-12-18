using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Nav : MonoBehaviour
{
    // Start is called before the first frame update
    public void Jouer(){
        SceneManager.LoadScene("Jeu");
    }
    public void Quitter(){
        Application.Quit();
    }
}
