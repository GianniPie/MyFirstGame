using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceFunctions : MonoBehaviour
{

    public Image die0, die1, die2, die3, die4;

    public void LockDice()
    {
        
        die0.GetComponent<Image>().color = Color.yellow;
    }



}
