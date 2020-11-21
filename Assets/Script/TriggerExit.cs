using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExit : MonoBehaviour
{

    //Appel le GameObject bille
    public GameObject bille;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Se déclenche quand la bille entre dans le collider du GameObject sortie
    private void OnTriggerEnter(Collider other)
    {
        //Envoit dans la console le mot "VICTOIRE"
        print("VICTOIRE");
    }
}
