using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoller : MonoBehaviour
{

    public int diceTotal;
    public int[] diceValues;
    public bool[] diceLocked;

    public Sprite[] diceImages;



    // Start is called before the first frame update
    void Start()
    {
        diceValues = new int[] {0,0,0,0,0};
        diceLocked = new bool[] {false,false,false,false,false};
    }



    // Update is called once per frame
    void Update()
    {
        
	}





    public void RollTheDice()
    {
    	
    	diceTotal = 0;
    	for (int i = 0; i < 5; i++)
    	{
    		if(diceLocked[i] == false)
    		{
	    		diceValues[i] = Random.Range(1,7);
	    		Debug.Log("Die" + i + ": " + diceValues[i]);
	    		diceTotal += diceValues[i];
	    		//Include animation
	    		this.transform.GetChild(i).GetComponent<Image>().sprite =  diceImages[diceValues[i]];
	    	}
    	}

    	this.transform.GetChild(5).GetComponent<Text>().text = "" + diceTotal;
    }

}
