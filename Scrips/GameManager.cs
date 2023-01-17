using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score;

    public bool gameOver = false;

    void Awake() // Awake ist das gleiche wie Start wird aber früher aktiviert und wenn das skribt disable ist
    {
        instance = this;
    }
}
