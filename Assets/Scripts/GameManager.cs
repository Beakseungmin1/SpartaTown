using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private InputField inputField;

    [SerializeField] private GameObject ChooseCha;


    public string PlayerName { get; private set; }

    public int PlayerChoose;

    public bool PlayerInMain;



    public static GameManager _instance { get; private set; }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;

        DontDestroyOnLoad(gameObject);

    }

    public void SetPlayerName(string playerName)
    {
        PlayerName = playerName;
    }


    public void ChanageToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void ShowChooseCha()
    {
        if (!ChooseCha.activeSelf)
        {
            ChooseCha.SetActive(true);
        }
    }

    public void HideChooseCha()
    {
        if (ChooseCha.activeSelf)
        {
            ChooseCha.SetActive(false);
        }
    }


    public void SetPlayerinMain()
    {
        PlayerInMain = true;
    }
}
