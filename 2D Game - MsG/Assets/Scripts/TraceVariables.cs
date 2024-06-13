using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraceVariables : MonoBehaviour
{
	public string myText = "Enter Text Here";
	private int coins = 0;
	private bool isClicked = false;
	public float speed = 3.5f;
	
	// This additional function does something if the player clicks the sprite
	void OnMouseDown()
	{
		isClicked = true;
	}
	
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myText);
		Debug.Log(speed);
    }

    // Update is called once per frame
    void Update()
    {
		if (isClicked == true)    // if (isClicked) is a shorthand way to write this line
		{
			coins = coins + 2;    // coins++; is a shorthand way to write this line
			Debug.Log(coins);
			isClicked = false;
		}
    }
}

/*

    BRIEFLY DESCRIBE YOUR OBSERVATIONS HERE AFTER TESTING IN UNITY
    
*/
