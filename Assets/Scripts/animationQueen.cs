using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class animationQueen : MonoBehaviour
{
    [SerializeField]
    Animator anim;

    public Action RayHitOp;

    // Start is called before the first frame update
    void Start()
    {
        anim = transform.GetComponentInChildren<Animator>();
        //rayCast_Queen = transform.GetComponent<rayCast_Queen>();
        RayHitOp += Hit;
    }
    void Hit()
    {
        anim.SetBool("isHit", true);

    }
    // Update is called once per frame
    void Update()
    {

    }
}
