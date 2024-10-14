using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{

    [SerializeField] private InputField inputField;

    private string PlayerName = null;


    private void Update()
    {
        PlayerName = inputField.text;
    }

    public void StartMainScene()
    {
        if (PlayerName.Length >= 2 && PlayerName.Length <= 10)
        {
            if (GameManager._instance.PlayerInMain)
            {
                GameManager._instance.SetPlayerName(PlayerName);
                UIManager._instance.HideNameChangeBox();
            }
            else
            {
                GameManager._instance.SetPlayerName(PlayerName);
                GameManager._instance.ChanageToMainScene();
            }
        }
        else
        {
            Debug.Log("올바른 입력이 아닙니다");
        }
    }

}
