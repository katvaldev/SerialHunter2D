using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ganaste : MonoBehaviour
{
    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuInicial");
    }
}
