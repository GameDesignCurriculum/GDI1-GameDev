using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetInventory : MonoBehaviour
{
    // Variables
    public bool adoptPet = false;

    //Class defining properties of food
    public class Pet
    {
        public string name;
        public int amount;
    }

    // Create instances of each food item with class properties
    Pet cat = new Pet();
    Pet dog = new Pet();
    Pet rabbit = new Pet();
    Pet hamster = new Pet();
    Pet feret = new Pet();

    // Do something when the sprite is clicked
    void OnMouseDown()
    {
        // Changes Boolean value to true when sprite is clicked
        adoptPet = true;
    }

    // Start is called before the first frame update
    void Start()
    {   
        // Set each food item's initial values
        cat.name = "Cat";
        cat.amount = 3;

        dog.name = "Dog";
        dog.amount = 4;

        rabbit.name = "Rabbit";
        rabbit.amount = 2;

        hamster.name = "Hamster";
        hamster.amount = 1;

        feret.name = "Feret";
        feret.amount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (adoptPet)  // Shorthand to check if `adoptPet` is true
        {
            // Update inventory
            cat.amount += 1;
            dog.amount += 1;
            rabbit.amount += 1;
            hamster.amount += 1;
            feret.amount += 1;

            // Print current inventory status to console
            Debug.Log(cat.name + " = " +  cat.amount);
            Debug.Log(dog.name + " = " +  dog.amount);
            Debug.Log(rabbit.name + " = " + rabbit.amount);
            Debug.Log(hamster.name + " = " +  hamster.amount);
            Debug.Log(feret.name + " = " + feret.amount);

            // Change Boolean `adoptPet` back to false value
            adoptPet = false;
        }
    }
}