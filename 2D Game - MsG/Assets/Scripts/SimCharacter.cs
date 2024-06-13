using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimCharacter : MonoBehaviour
{

    // CREATE YOUR FOUR VARIABLES HERE
    private bool hasPet = false;
    public string greeting = "Greetings!";
    private float health = 4.5f;
    public int players = 0;

    void OnMouseDown()
    {
        hasPet= true;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(greeting);
        Debug.Log("There are " + players + " players in this game.");
        Debug.Log("Your health is " + health + ".");
    }

    // Update is called once per frame
    void Update()
    {
        if (hasPet)
        {
            Debug.Log("You adopted a fluffy puppy! Woof!");
            hasPet = false;
        }
    }
}
