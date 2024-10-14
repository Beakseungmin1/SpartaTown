using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public static PlayerManager _instance { get; private set; }

    [SerializeField] private GameObject Player1;
    [SerializeField] private GameObject Player2;


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;

        if (GameManager._instance.PlayerInMain)
        {
            Player1 = Instantiate(Player1);
            Player2 = Instantiate(Player2);

            Player1.SetActive(false);
            Player2.SetActive(false);

            Debug.Log(GameManager._instance.PlayerChoose);
            if (GameManager._instance.PlayerChoose < 2)
            {
                Player1.SetActive(true);
            }
            else
            {
                Player2.SetActive(true);
            }
        }

    }

    public void ChangePlayer1()
    {
        if (GameManager._instance.PlayerChoose == 1)
        {
            Player1.transform.position = Player2.transform.position;
            Player2.SetActive(false);
            Player1.SetActive(true);
        }
    }

    public void ChangePlayer2()
    {
        if (GameManager._instance.PlayerChoose == 2)
        {
            Player2.transform.position = Player1.transform.position;
            Player1.SetActive(false);
            Player2.SetActive(true);
        }
    }


}
