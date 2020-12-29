using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DiceValues = new int[4];
    }

    public Sprite[] DiceImageOne;
    public Sprite[] DiceImageZero;

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool doneRolling = false;

    public int[] DiceValues;
    public int DiceTotal;
    


    public void NewTurn()
    {
        //This is the start of the player turn
        // We dont have a roll for them yet.

        doneRolling = false;

    }
            
    public void RollTheDice()
    {
        // In Ur , you roll four dice (classically Tetrahedron),
        // have half their face have a value of "1" and half a value of zero

        DiceTotal = 0;
        for (int i = 0; i < DiceValues.Length; i++)
        {
            DiceValues[i] = Random.Range(0 , 2);
            DiceTotal += DiceValues[i];


            if(DiceValues[i] == 0)
            {
                this.transform.GetChild(i).GetComponent<Image>().sprite = 
                    DiceImageZero[Random.Range(0,DiceImageZero.Length)];
            }
            else
            {
                this.transform.GetChild(i).GetComponent<Image>().sprite =
                    DiceImageOne[Random.Range(0, DiceImageOne.Length)];
            }

            doneRolling = true;
            
        }

        // Update the visuals to show the dice roll
        // 

       // Debug.Log("Rolled: " + DiceTotal);

    }
}
