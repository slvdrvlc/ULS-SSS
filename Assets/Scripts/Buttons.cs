using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buttons : MonoBehaviour
{
    void start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Menu()
    {
        SceneManager.LoadScene(2);
    }
    public void Instrucciones()
    {
        SceneManager.LoadScene(3);

    }
    public void LevelEasy()
    {
        SceneManager.LoadScene(4);
    }
    public void Lose()
    {
        SceneManager.LoadScene(5);
    }
    public void Win()
    {
        SceneManager.LoadScene(6);
    }
    public void Credits()
    {
        SceneManager.LoadScene(7);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
