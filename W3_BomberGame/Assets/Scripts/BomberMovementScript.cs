using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberMovementScript : MonoBehaviour
{
    public float bomberSpeed; //define and init bomber speed

    // Start is called before the first frame update
    void Start()
    {
        bomberSpeed = -2f;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello?");
        //get the current position of the bomber
        Vector3 bomberPos = transform.position;

        //change the vector position
        bomberPos.x += bomberSpeed * Time.deltaTime;

        transform.position = bomberPos; //move the bomber to the new position
    }
}
