using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public skinmanager skinDB;

    public SpriteRenderer sr;
    private int selectedOption = 0;

    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            load();
        }
        UpdateSkin(selectedOption);
    }

    private void UpdateSkin(int selectedOption)
    {
        Skin skin = skinDB.GetSelectedSkin(selectedOption);
        sr.sprite = skin.skinSprite;
    }

    private void load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

}
