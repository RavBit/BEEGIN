using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DetailView : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Text _labelTitle;
    [SerializeField] private Text _labelDescription;
    [SerializeField] private Button _buttonClose;

    public void Initialize(Sprite image, string title, string description)
    {
        _image.sprite = image;
        _labelTitle.text = title;
        _labelDescription.text = description;
        _buttonClose.onClick.AddListener(OnButtonClicked);
    }


    private void OnButtonClicked()
    {
        _buttonClose.onClick.RemoveListener(OnButtonClicked);
        transform.DOMoveX(1640, 0.3f);
    }
}