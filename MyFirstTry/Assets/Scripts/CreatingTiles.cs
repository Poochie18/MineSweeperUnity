using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingTiles : MonoBehaviour
{
    private static CreatingTiles instance;
    public static CreatingTiles Instance { get { return instance; } }

    public GameObject Tile;
    public GameObject[,] Tiles;
    public Sprite tiles;
    public Sprite[] emptyTiles;
    public Sprite mines;
    public int height;
    public int weight;
    public static bool mine;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        Creating();
    }

    public void Creating()
    {
        //int number = 0;
        Tiles = new GameObject[height, weight];
        float size_x = Tile.GetComponent<BoxCollider2D>().size.x;
        float size_y = Tile.GetComponent<BoxCollider2D>().size.y;

        float posX = -size_x * ((float)weight / 2 + 1);
        float posY = -size_y * ((float)height / 2 - 1);


        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < weight; j++)
            {

                posX += size_x;
                Tile.GetComponent<SpriteRenderer>().sprite = tiles;
                Tiles[i,j] = Instantiate(Tile, new Vector3(posX, posY), Quaternion.identity);
                
            }
            posY += size_y;
            posX = -size_x * ((float)weight / 2 + 1);
        }
    }

    public void LoadTexture(GameObject tile, int number)
    {
        tile.GetComponent<SpriteRenderer>().sprite = emptyTiles[number];
        /*mine = Random.value < 0.15;
        if (mine)
        {
            Tile.GetComponent<SpriteRenderer>().sprite = mines;
        }
        else
        {
            
        }*/
    }


}


