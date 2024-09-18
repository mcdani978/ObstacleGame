using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour


{
    public float bombSpeed;
    // Start is called before the first frame update
    void Start()
    {
        bombSpeed = -3f;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 bombpos = transform.position;
        bombpos.x += Time.deltaTime * bombSpeed;
        transform.position = bombpos;
    }
}
    