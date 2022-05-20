using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreditMenu : Menu
{
    [Header("UI References :")]
    public TMP_Text _devText;
    public TMP_Text _sfxText; 
    [Space]
    [SerializeField] Button _backButton;

    [Header("Database References :")]
    [SerializeField] UIData _data;

    private void OnEnable()
    {
        _backButton.interactable = true; 

        //_devText.text = _data.DevText;
       // _sfxText.text = _data.SfxTxt;
       
    }

    private void Start()
    {
        OnButtonPressed(_backButton, BackButtonPressed);
    }

    private void BackButtonPressed()
    {
        _backButton.interactable = false;
        MenuController.GetInstance().CloseMenu();
    }
}
