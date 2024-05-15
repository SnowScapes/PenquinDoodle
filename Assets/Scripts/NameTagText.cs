using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameTagText : MonoBehaviour, IUiText
{
    [SerializeField] private Text nameTagText;

    private void Start()
    {
        SetText(GameManager.Instance.PlayerName);
    }

    public void SetText(string _name)
    {
        nameTagText.text = _name;
    }
}
