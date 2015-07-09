using UnityEngine;
using System.Collections;

public class Node {

    int positionX;
    int positionY;
    int Occupied = 0;

    public Node(int posX, int posY)
    {
        positionX = posX;
        positionY = posY;
    }


    public void SetValue(bool value)
    {

        Occupied = value ? 1 : 0;
   
    }

    public int getValue()
    {
        return Occupied;
    }

}
