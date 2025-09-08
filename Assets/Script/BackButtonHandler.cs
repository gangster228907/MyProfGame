using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonHandler : MonoBehaviour
{
    private string previousScene;

    void Start()
    {
        // ��������� ���������� �����, ���� ����
        if (PlayerPrefs.HasKey("LastScene"))
            previousScene = PlayerPrefs.GetString("LastScene");

        // ��������� ������� ����� ��� "���������" ��� ���������� ����
        PlayerPrefs.SetString("LastScene", SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // ������ "�����" �� Android
        {
            if (!string.IsNullOrEmpty(previousScene))
            {
                SceneManager.LoadScene(previousScene);
            }
            else
            {
                // ���� ���������� ����� ��� ? ������� �� ����
                Application.Quit();
            }
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject); // ������ �� ������������ ��� �������� ����� �����
    }
}
