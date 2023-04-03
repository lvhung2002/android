using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
    public void ChoiMoi() {
        SceneManager.LoadScene(1);
    }

    public void Thoat() {
        Application.Quit();
    }

    public void CuaHang() {
        SceneManager.LoadScene(2);
    }
}
