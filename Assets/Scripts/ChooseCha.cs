using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCha : MonoBehaviour
{
    [SerializeField] private GameObject Chaimg1;
    [SerializeField] private GameObject Chaimg2;


    public void ChooseCha1()
    {
        GameManager._instance.PlayerChoose = 1;

        if (GameManager._instance.PlayerInMain)
        {
            PlayerManager._instance.ChangePlayer1();
        }
        else
        {
            if (Chaimg2.activeSelf)
            {
                Chaimg2.SetActive(false);
                Chaimg1.SetActive(true);
            }
        }

    }

    public void ChooseCha2()
    {
        GameManager._instance.PlayerChoose = 2;

        if (GameManager._instance.PlayerInMain)
        {
            PlayerManager._instance.ChangePlayer2();
        }
        else
        {
            if (Chaimg1.activeSelf)
            {
                Chaimg1.SetActive(false);
                Chaimg2.SetActive(true);
            }
        }

    }
}
