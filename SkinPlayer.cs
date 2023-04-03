using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SkinPlayer : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    private int player1 = 0;
    public GameObject skinmanager;

    public void Next()
    {
        player1 = player1 + 1;
        if (player1 == skins.Count)
        {
            player1 = 0;
        }
        sr.sprite = skins[player1];
    }

    public void Back()
    {
        player1 = player1 - 1;
        if (player1 < 0)
        {
            player1 = skins.Count - 1;
        }
        sr.sprite = skins[player1];
    }

    public void PlayGame()
    {
        PrefabUtility.SaveAsPrefabAsset(skinmanager, "Assets/SkinPlayer/player1.prefab");
        SceneManager.LoadScene("SampleScene");
    }
}
