using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbitter : MonoBehaviour
{
    private Vector3 center;

    public float speed;
    void Start()
    {
        center = new Vector3(0, transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(center, Vector3.up, speed * Time.deltaTime);
    }
}
