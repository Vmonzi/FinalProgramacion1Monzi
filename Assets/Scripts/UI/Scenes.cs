using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{

    public string sceneBoss;
    public string sceneMini;
    public string sceneWin;
    bool _menu = false;
    public GameObject menuPausa;
  
    private void Update()
    {
        //MenuPausa
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _menu = !_menu;
        }

        if (_menu)
        {
            menuPausa.SetActive(true);
            Time.timeScale = 0;
        }

        else
        {
            MenuDesactivado();
        }
    }

    public void Continuar()
    {
        MenuDesactivado();
        _menu = false;
    }

    public void MenuDesactivado()
    {
        menuPausa.SetActive(false);
        Time.timeScale = 1;
    }
    public void LoadLevel(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void Exit()
     {
        Application.Quit();
     }

    public void GolevelBoss()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(sceneBoss);
        }
    }
    public void GolevelMiniBoss()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(sceneMini);
        }
    }

    public void SceneWin()
    {
        SceneManager.LoadScene(sceneWin);
        
    }

}
