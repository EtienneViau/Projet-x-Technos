using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPuzzle : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator _anim;
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="key")
        {
            Debug.Log("Proute");
        }
        
    }
    

}
