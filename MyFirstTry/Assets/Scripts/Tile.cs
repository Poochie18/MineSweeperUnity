using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public GameObject tile;
    public Sprite def;
    public Sprite mine;
    public Sprite[] otherTiles;
    public bool isMine;
    public bool isClosed;

    /*private static Tile instance;
    public static Tile Instance { get { return instance; } }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }*/

    public float SizeOfx()
    {
        return tile.GetComponent<BoxCollider2D>().size.x;
    }

    public float SizeOfy()
    {
        return tile.GetComponent<BoxCollider2D>().size.y;
    }

    public void DefaultSkin()
    {
        tile.GetComponent<SpriteRenderer>().sprite = def;
    }

    public Tile Inizialisation(Tile tile, float pos_x, float pos_y)
    {
        return Instantiate(tile, new Vector2(pos_x, pos_y), Quaternion.identity);
    }
}
