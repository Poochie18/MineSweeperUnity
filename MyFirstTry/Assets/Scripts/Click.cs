using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    
    private void OnMouseDown()
    {
        Debug.Log(transform.position);
        CreatingTiles.Instance.LoadTexture(gameObject, 1); 
    }


}
