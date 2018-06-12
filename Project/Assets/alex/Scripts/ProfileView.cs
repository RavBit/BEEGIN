﻿using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ProfileView : MonoBehaviour
{
    [SerializeField] private Piece[] _pieces;
    [SerializeField] private Text _labelProfession;
    [SerializeField] private Text _labelPun;
    [SerializeField] private Button _buttonClose;
    [SerializeField] private Image _imageCrown;
    

    public void Initialize(Item[] items, string profession, string pun, bool isOwner)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (i > 5)
                break;
            
            _pieces[i].Initialize(items[i].sprite, items[i].title, items[i].description);
        }

        _labelProfession.text = profession;
        _labelPun.text = pun;
        _buttonClose.onClick.AddListener(OnButtonClicked);
        _imageCrown.gameObject.SetActive(isOwner);
    }

    private void OnButtonClicked()
    {
        _buttonClose.onClick.RemoveListener(OnButtonClicked);
        transform.DOMoveX(1620, 0.3f);

        View.instance.SetHeader("My hive");
    }
}