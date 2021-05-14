using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class rayCast_Queen : MonoBehaviour
{
    [SerializeField]
    animationQueen animQueen;
    // Start is called before the first frame update
    void Start()
    {
        animQueen = transform.GetComponent<animationQueen>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 1000;

        Debug.DrawRay(transform.position, forward, Color.red);

        if (Physics.Raycast(transform.position, forward, out hit))
        {
            Debug.Log("Something hit by Queen");
            animQueen.RayHitOp();
        }
    }

}
