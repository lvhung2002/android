using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shop : MonoBehaviour
{
    public skinmanager skinDB;

    public SpriteRenderer sr;
    private int selectedOption = 0;

    void Start() {
        if (!PlayerPrefs.HasKey("selectedOption")) {
            selectedOption = 0;
        }
        else {
            load();
        }
        UpdateSkin(selectedOption);
    }


    public void next() {
        selectedOption++;
        if (selectedOption >= skinDB.skinCount) {
            selectedOption = 0;
        }
        UpdateSkin(selectedOption);
        Save();
    }

    public void back()
    {
        selectedOption--;
        if (selectedOption <0)
        {
            selectedOption = skinDB.skinCount - 1;
        }
        UpdateSkin(selectedOption);
        Save();
    }

    private void UpdateSkin(int selectedOption) {
        Skin skin = skinDB.GetSelectedSkin(selectedOption);
        sr.sprite = skin.skinSprite;
    }

    private void load() {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    private void Save() {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }

    public void skinScene(int sceneID) {
        SceneManager.LoadScene(sceneID);
    }

}


