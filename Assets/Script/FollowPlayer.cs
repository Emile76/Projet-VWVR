using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Va chercher le GameObject bille
    public GameObject bille;
    //Valeur offset
    private Vector3 offset = new Vector3(6.44f, 0f, 0f);

    // Start is called before the first frame update
    void Start()
    {

    }


    void LateUpdate()
    {
        // Adapte position caméra à celle de bille, en ajoutant un décalage (offset)
        transform.position = bille.transform.position + offset;

    }
}
