using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    
   public AudioSource GameOverS;
    
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        GameOverS = GetComponent<AudioSource>();
    }

   
    void Update()
    {
        if(GameManager.instance.gameOver == true && textMesh.enabled == false)
        {
            textMesh.enabled = true;
        }
    }

    public void GoBackMenu()
    {   
        SceneManager.LoadScene("Menu");
    }
    public void Restar()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
