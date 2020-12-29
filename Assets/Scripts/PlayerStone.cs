using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //theDiceRoller = GameObject.FindObjectOfType<DiceRoller>();
    }

    public Tile StartingTile;
    Tile currentTile;

    public DiceRoller theDiceRoller;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        Debug.Log("Click");

        if (theDiceRoller.doneRolling == false)
        {
            // We can't move yet.
            return;
        }

        int spacesToMove = theDiceRoller.DiceTotal;

        // where should we end up

        if(spacesToMove == 0)
        {
            return;
        }

        Tile finalTile = currentTile;

        for (int i = 0; i < spacesToMove; i++)
        {
            if (finalTile == null)
            {
                finalTile = StartingTile;
            }
            else
            {
                finalTile = finalTile.NextTiles[0]; 
            }

        }

        if(finalTile == null)
        {
            // we moved an off board tile by zero
            return;
        }

        // teleport the tile to final tile

        // todo ANIMATE !

        this.transform.position = finalTile.transform.position;
        
        currentTile = finalTile;
       
    }
}
