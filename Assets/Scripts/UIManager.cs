using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject NameChangeBox;

    [SerializeField] private GameObject ChooseCha;
    public static UIManager _instance { get; private set; }
    
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;

    }


    public void ShowNameChangeBox()
    {
        if (!NameChangeBox.activeSelf)
        {
            NameChangeBox.SetActive(true);
        }
    }

    public void HideNameChangeBox()
    {
        if (NameChangeBox.activeSelf)
        {
            NameChangeBox.SetActive(false);
        }
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

}
