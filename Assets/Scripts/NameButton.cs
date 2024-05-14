using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameButton : MonoBehaviour , IUiButton
{
    [SerializeField] private InputField inputField_Name;
    [SerializeField] private GameObject invalid_Popup;

    private Regex valid_Name = new Regex("[a-zA-Z\\uAC00-\\uD7A3]{2,10}"); // 입력받은 문자가 2~10글자의 알파벳 또는 한글이라는 뜻의 정규식

    public void OnClick()
    {
        if (valid_Name.IsMatch(inputField_Name.text))
        {
            GameManager.Instance.PlayerName = inputField_Name.text;
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            StartCoroutine(ShowPopup());
        }
    }

    private IEnumerator ShowPopup()
    {
        invalid_Popup.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        invalid_Popup.SetActive(false);
    }
}
