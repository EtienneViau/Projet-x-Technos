using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RammasserTouteLesObjets : MonoBehaviour
{
    private int _objetRamasser=0;
    public GameObject ArbreRoue;
    public GameObject ArbreAmpoule;
    public GameObject ArbrePourAmpoule;
    public AudioClip achievement;
    public AudioSource audioSource;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_objetRamasser==4){
            ArbreRoue.SetActive(false);
        }
        if(_objetRamasser==5){
            ArbreAmpoule.SetActive(false);
            ArbrePourAmpoule.SetActive(false);
        }
        if(_objetRamasser==6){
            Debug.Log("TU AS GAGNER");
            SceneManager.LoadScene("MainMenu");
        }
    }
    public void AjouterUnObjet(){
        _objetRamasser++;
        Debug.Log(_objetRamasser);
    }
    public void EnleverUnObjet(){
        _objetRamasser--;
        Debug.Log(_objetRamasser);
    }
    
}
