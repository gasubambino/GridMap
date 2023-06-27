using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int width, height;
    [SerializeField] private Tile tilePrefab;

    public Dictionary<Vector2, Tile> tiles;
    private void Start()
    {
        GenerateGrid();
    }
    void GenerateGrid()
    {
        tiles = new Dictionary<Vector2, Tile>();
        for(int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                var spawnedTile = Instantiate(tilePrefab, new Vector3(-18.6f + i*2, -14.3f + j *2),Quaternion.identity, transform);
                tiles[new Vector2(-18.6f + i * 2, -14.3f + j * 2)] = spawnedTile;
            }
        }
    }

    public Tile GetTileAtPosition(Vector2 position)
    {
        if (tiles.TryGetValue(position, out var tile))
        {
            return tile;
        }
        return null;
    }
}
