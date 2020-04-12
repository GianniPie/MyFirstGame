using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DiceValues = new int[5];
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    public int[] DiceValues;
    

    public void RollTheDice()
    {

    	for (int i = 0; i < 5; i++)
    	{
    		DiceValues[i] = Random.Range(1,7);
    		Debug.Log("Die" + i + ": " + DiceValues[i]);

    	}

    }
}
