using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.Player = Instantiate(GameManager.Instance.PlayerPref);
        Destroy(gameObject);
    }
}
