﻿using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Profile : MonoBehaviour
{
    [SerializeField] private string _profession;
    [SerializeField] private string _pun;
    [SerializeField] private bool _isOwner;
    [SerializeField] private Item[] _items;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(OnButtonClicked);
    }


    private void OnButtonClicked()
    {
        View.instance.ProfileView.Initialize(_items, _profession, _pun, _isOwner);
        View.instance.ProfileView.transform.DOMoveX(540, 0.3f);
        View.instance.SetHeader("Worker Bee");
    }
}