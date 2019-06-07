using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("Mapa");
    }

   public void QuitGame()
    {
        Application.Quit();
    }

    public void Configurações()
    {
        SceneManager.LoadScene("Configurações");
    }

    public void Créditos()
    {
        SceneManager.LoadScene("Créditos");
    }

    public void MenuP()
    {
        SceneManager.LoadScene("Menu");
    }
}