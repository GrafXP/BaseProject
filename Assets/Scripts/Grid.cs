using UnityEngine;
using System.Collections;


public class Grid {


    //Grid unoccupied = 0
    //Grid start = 1
    //Grid End = 2
    //Grid Obstacle = 3
    
    public int [,] GridArray = new int [64, 64];


    public void SetStartNode(int posX, int posY)
    {
        GridArray[posX, posY] = 1;
    }

    public void setEndTargetNode(int posX, int posY)
    {
        GridArray[posX, posY] = 2;
    }

    public void SetObstacle(int posX, int posY)
    {
        GridArray[posX, posY] = 3;
    }

    public int GetNodeStatus(int posX, int posY)
    {
        return GridArray[posX, posY];
    }
	
}
