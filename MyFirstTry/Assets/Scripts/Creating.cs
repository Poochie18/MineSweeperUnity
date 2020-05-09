using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creating : MonoBehaviour
{
    private static Creating instance;
    public static Creating Instance { get { return instance; } }

    public Tile tile;
    public Tile[,] tileMap;

    public int height;
    public int weight;

    public bool mine;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        TilePos();
    }

    void TilePos()
    {
        tileMap = new Tile[height, weight];
        float size_x = tile.SizeOfx();
        float size_y = tile.SizeOfy();

        print(size_x);
        float posX = -size_x * ((float)weight / 2 + 1);
        float posY = -size_y * ((float)height / 2 - 1);


        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < weight; j++)
            {
                print(posX);
                posX += size_x;
                tile.DefaultSkin();
                tileMap[i, j] = tile.Inizialisation(tile,posX, posY);
                if (mine = Random.value < 0.3) { tileMap[i,j].isMine = true;}
            }
            posY += size_y;
            posX = -size_x * ((float)weight / 2 + 1);
        }
    }
}
