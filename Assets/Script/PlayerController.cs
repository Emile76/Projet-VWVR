using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Établit horizontalInput
    private float horizontalInput;
    //Valeur turnSpeed
    private float turnSpeed = 50;
    //Valeur point d'origine du labyrinthe
    private Vector3 origin = new Vector3(0.0f, -5.5f, 5.5f);
    //Valeur de rotation par défaut du labyrinthe
    private Quaternion rotationDefaut = new Quaternion(0, 0, 0, 1);



    // Start is called before the first frame update
    void Start()
    {

        origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        //Identifie valeur horizontal
        horizontalInput = Input.GetAxis("Horizontal");

        //Permet la rotation du labyrinth sur l'axe horizontal grace aux touches a et d
        transform.RotateAround(origin, Vector3.left, turnSpeed * horizontalInput * Time.deltaTime);
        //Quand on appuit sur la touche espace, le labyrinth se remet à son point de rotation de base
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.rotation = rotationDefaut;

        }
    }

}
