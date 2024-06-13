using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolInventory : MonoBehaviour
{
    public bool getTool = false;

    // CREATE a public `class' defining properties for tools
    // Include a variables `name` and `amount` - don't forget variable types for each
    public class Tool
        {
        public string item;
        public int amount;
        }
    // CREATE at least 3 new tools using the `Tool()` class you created above

    Tool hammer = new Tool();
    Tool drill = new Tool();
    Tool saw = new Tool();

    void OnMouseDown()
    {
        getTool = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        // CREATE each tool's initial values - a different name and an amount for each        
        hammer.item = "Hammer";
        hammer.amount = 2;
        drill.item = "Drill";
        drill.amount = 1;
        saw.item = "Saw";
        saw.amount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (getTool)
        {
            // UPDATE each inventory item's amount by incrementing - an example one is below
            // hammers.amount += 1;
            hammer.amount += 1;
            drill.amount += 1;
            saw.amount += 1;

            // PRINT an updated inventory status to the console for each item - an example one is below
            // Debug.Log(hammers.name + " = " +  hammers.amount);
            Debug.Log(hammer.item + " = " + hammer.amount);
            Debug.Log(drill.item + " = " + drill.amount);
            Debug.Log(saw.item + " = " + saw.amount);

            // Leave this code here to prevent continuous updating
            getTool = false;
        }
    }
}