using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    public static View instance;

    [SerializeField] private Text _labelHeader;
    [SerializeField] private Button _buttonMenu;
    [SerializeField] private Image _imageOverlay;

    [SerializeField] private ProfileView _profileView;
    [SerializeField] private DetailView _detailView;

    private void Awake()
    {
        if (!instance)
            instance = this;

        _buttonMenu.onClick.AddListener(OnButtonClicked);

        SetOverlay(false);
    }


    private void OnButtonClicked()
    {
        Debug.Log("Open/close menu.");
    }


    private void SetOverlay(bool active)
    {
        _imageOverlay.gameObject.SetActive(active);

        _imageOverlay.DOFade(active ? 0.5f : 0f, 0.3f);
    }



    public void SetHeader(string title)
    {
        _labelHeader.text = title;
    }



    public DetailView DetailView
    {
        get { return _detailView; }
    }

    public ProfileView ProfileView
    {
        get { return _profileView; }
    }
}