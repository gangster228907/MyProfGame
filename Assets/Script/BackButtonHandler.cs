using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonHandler : MonoBehaviour
{
    private string previousScene;

    void Start()
    {
        // сохраняем предыдущую сцену, если есть
        if (PlayerPrefs.HasKey("LastScene"))
            previousScene = PlayerPrefs.GetString("LastScene");

        // сохраняем текущую сцену как "последнюю" для следующего раза
        PlayerPrefs.SetString("LastScene", SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // кнопка "Назад" на Android
        {
            if (!string.IsNullOrEmpty(previousScene))
            {
                SceneManager.LoadScene(previousScene);
            }
            else
            {
                // если предыдущей сцены нет ? выходим из игры
                Application.Quit();
            }
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject); // объект не уничтожается при загрузке новой сцены
    }
}
