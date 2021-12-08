using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float timing=600.0f;
    [SerializeField] private Text _decompte;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Chrono",1.0f,1.0f);
    }

    private void Chrono() {
        // if(_timer==0){
        //     SceneManager.LoadScene("Fin");
        // }else{
        timing--;
        _decompte.text=timing.ToString();
        // }
    }
}
