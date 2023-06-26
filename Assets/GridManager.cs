using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int width, height;
    [SerializeField] private Tile tilePrefab;

    private void Start()
    {
        GenerateGrid();
    }
    void GenerateGrid()
    {
        for(int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                var spawnedTile = Instantiate(tilePrefab, new Vector3(i*2,j*2),Quaternion.identity);
            }
        }
    }
}
