using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinManager", menuName = "Skin Manager")]
public class skinmanager : ScriptableObject
{
    [SerializeField] public Skin[] skins;

    public int skinCount
    {
        get {
            return skins.Length;
        }
    }

    public Skin GetSelectedSkin(int skinIndex)
    {
            return skins[skinIndex];

    }

}
