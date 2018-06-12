using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Profile : MonoBehaviour
{
    [SerializeField] private string _profession;
    [SerializeField] private string _pun;
    [SerializeField] private bool _isOwner;
    [SerializeField] private Item[] _items;

    [SerializeField] private Sprite _spriteBee;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(OnButtonClicked);
    }


    private void OnButtonClicked()
    {
        View.instance.ProfileView.Initialize(_items, _profession, _pun, _isOwner, this);
        View.instance.ProfileView.transform.DOMoveX(540, 0.3f);
        View.instance.SetHeader("Worker Bee");
    }


    // accept
    public void Groetjes()
    {
        // change sprite
        GetComponent<Button>().onClick.RemoveAllListeners();
        GetComponent<Image>().sprite = _spriteBee;
        GetComponent<Image>().SetNativeSize();
        Destroy(GetComponent<Button>());
    }


    // decline
    public void FijneAvond()
    {
        Destroy(gameObject);
    }
}