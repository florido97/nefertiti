﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movment = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movment * speed, ForceMode2D.Force);
    }
}
