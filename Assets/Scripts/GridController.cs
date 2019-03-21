using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{

    public int rows;
    public int columns;
    Cube[,] tileMatrix;
    private int id;
    public Cube cubo;
    private const float incOffsetX = 0.125f;
    private const float incOffsetY = 0.2f;
    private float offsetX;
    private float offsetY;


    // Use this for initialization
    void Awake()
    {

        offsetY = 0;
        tileMatrix = new Cube[rows, columns];

        id = 0;

        for (int i = 0; i < rows; i++)
        {
            offsetX = 0;
            for (int j = 0; j < columns; j++)
            {
                //Instancio y creo una variable tipo Tile
                Cube c = Instantiate(cubo, new Vector3(j * 2, i * 2, 0), Quaternion.identity);
                c.miPosicionEnX = j;
                c.miPosicionEnY = i;
                tileMatrix[i, j] = c;
                id++;
                c.miID = id;
                c.miOffSetX = offsetX;
                c.miOffSetY = offsetY;
                offsetX += incOffsetX;
            }
            offsetY += incOffsetY;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

}
