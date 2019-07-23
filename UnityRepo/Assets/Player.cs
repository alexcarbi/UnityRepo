﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public float MoveSpeed = 600f;

    float movement = 0f; 

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        Debug.Log("Im moving mom "+movement);
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -MoveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collition");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
