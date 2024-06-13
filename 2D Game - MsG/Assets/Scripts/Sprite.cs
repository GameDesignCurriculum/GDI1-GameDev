using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite : MonoBehaviour
    {
    public float speed = 2;

    void Start()
        {
        Debug.Log("Hello Game World!");
        }

    void Update()
        {
        Vector2 position = transform.position;
        position += Vector2.left +Vector2.up * speed * Time.deltaTime;
        transform.position = position;
        }
    }

/*

    BRIEFLY DESCRIBE YOUR OBSERVATIONS HERE AFTER TESTING IN UNITY
    
*/