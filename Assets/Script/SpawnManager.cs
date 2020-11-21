using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Ajout d'un tableau dans le SpawnManager lui permettant de chercher...
    //...le GameObject billePrefab
    public GameObject billePrefab;
    //...de transformer labyrinthPivot
    public Transform labyrinthPivot;
    //...la caméra cam ayant le script FollowPlayer relié dessus
    public FollowPlayer cam;
    //...la sortie ayant le script TriggerExit relié dessus
    public TriggerExit sortie;
    //...le GameObject billeClone
    private GameObject billeClone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Si on appuie sur la touche espace...
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Et si billeClone est déjà créé...
            if (billeClone)
            {
                //Détruit billeClone
                Destroy(billeClone);
            }
            // Sinon, crée billeClone dans le GameObject labyrinthPivot
            billeClone = Instantiate(billePrefab, transform.position, new Quaternion (0, 0, 0, 1), labyrinthPivot);
            //Remplace l'élément bille dans cam et dans sortie par billeClone
            cam.bille = billeClone;
            sortie.bille = billeClone;
        }
        
    }
}
