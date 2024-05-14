using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterButton : MonoBehaviour
{
    [SerializeField] private Button[] _buttons;

    private void Start()
    {
        for (int i = 0; i < _buttons.Length; i++)
        {
            int index = i;
            _buttons[i].onClick.AddListener(() => OnClick(index));
        }
    }

    public void OnClick(int buttonIndex)
    {
        string path = "";
        switch (buttonIndex)
        {
            case 0 : path = "Characters/FMage";
                break;
            case 1 : path = "Characters/Penguin";
                break;
            case 2 : path = "Characters/MMage";
                break;
        }
        GameManager.Instance.PlayerPref = Resources.Load<GameObject>(path);
    }
}
