using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameBox : MonoBehaviour
{
    [SerializeField] private Text NameText;
    private GameObject Player;
    private Vector3 offset;

    private void Awake()
    {
        offset = new Vector3(0f, 100f, 0f);

    }

    //private void Start()
    //{
    //    Player = GameObject.FindGameObjectWithTag("Player");
    //}


    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(Player.transform.position) + offset;
        this.transform.position = screenPosition;
        NameText.text = GameManager._instance.PlayerName;
    }

}
