using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menü : MonoBehaviour
{
    public void GoToGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void OptionsGame()
    {
        SceneManager.LoadScene("Settings");
    }
    public void LeaveGame()
    {
        Application.Quit();
    }
}
