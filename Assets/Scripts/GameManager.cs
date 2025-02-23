using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } // Singleton

    public int vidas = 5;

    private void Awake()
    {
        // Configurar el Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); // Evitar duplicados
        }
    }

    public void PerderVidas()
    {
        vidas--;
    }

    public void ResetLevel()
    {
        FindObjectsOfType<pelota>()[0].ResetBall();
        FindObjectsOfType<jugador>()[0].ResetPlayer();

    }
}