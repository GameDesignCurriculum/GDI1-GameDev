using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInventory : MonoBehaviour
{
    // Variables
    public bool useFood = false;

    //Class defining properties of food
    public class Food
    {
        public string name;
        public int amount;
    }

    // Create instances of each food item with class properties
    Food berries = new Food();
    Food carrots = new Food();
    Food lettuce = new Food();
    Food apples = new Food();
    Food pears = new Food();

    // Do something when the sprite is clicked
    void OnMouseDown()
    {
        // Changes Boolean value to true when sprite is clicked
        useFood = true;
    }

    // Start is called before the first frame update
    void Start()
    {   
        // Set each food item's initial values
        berries.name = "Berries";
        berries.amount = 3;

        carrots.name = "Carrots";
        carrots.amount = 4;

        lettuce.name = "Lettuce";
        lettuce.amount = 2;

        apples.name = "Apples";
        apples.amount = 1;

        pears.name = "Pears";
        pears.amount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (useFood)  // Shorthand to check if `useFood` is true
        {
            // Update inventory
            berries.amount += 1;
            carrots.amount -= 1;
            lettuce.amount -= 1;
            apples.amount -= 1;
            pears.amount += 1;

            // Print current inventory status to console
            Debug.Log(berries.name + " = " +  berries.amount);
            if (carrots.amount > -1)
            {
                Debug.Log(carrots.name + " = " +  carrots.amount);
            }
            if (lettuce.amount > -1)
            {
                Debug.Log(lettuce.name + " = " + lettuce.amount);
            }
            if (apples.amount > -1)
            {
                Debug.Log(apples.name + " = " +  apples.amount);
            }
            Debug.Log(pears.name + " = " + pears.amount);

            // Change Boolean `useFood` back to false value
            useFood = false;
        }
    }
}

/*

    BRIEFLY DESCRIBE YOUR OBSERVATIONS HERE AFTER TESTING IN UNITY

*/