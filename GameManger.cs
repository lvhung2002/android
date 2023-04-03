using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{

    public GameObject playerskin;
    public GameObject Player;
    private Sprite playersprite;

    // Start is called before the first frame update
    void Start()
    {
        playersprite = playerskin.GetComponent<SpriteRenderer>().sprite;
        Player.GetComponent<SpriteRenderer>().sprite = playersprite;
    }

   
}
