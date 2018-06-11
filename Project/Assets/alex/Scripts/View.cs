using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    public static View instance;

    [SerializeField] private Text _labelHeader;

    [SerializeField] private ProfileView _profileView;
    [SerializeField] private DetailView _detailView;

    private void Awake()
    {
        if (!instance)
            instance = this;
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