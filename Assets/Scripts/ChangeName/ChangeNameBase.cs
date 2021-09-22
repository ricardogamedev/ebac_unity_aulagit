using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeNameBase : MonoBehaviour
{
    [Header("References")]
    public TextMeshProUGUI uiTextName;
    public TMP_InputField uiInputField;
    public GameObject changeNameImput;
    public Player player;

    private string playerName;

    void Start()
    {

    }
    
    public void ChangeName()
    {
        playerName = uiInputField.text;
        uiTextName.text = playerName;
        changeNameImput.SetActive(false);
        player.SetName(playerName);
    }
}
