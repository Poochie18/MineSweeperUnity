using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        CreatingTiles creating = gameObject.GetComponent(typeof(CreatingTiles)) as CreatingTiles;
        Debug.Log("Start");
        creating.Creating();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
