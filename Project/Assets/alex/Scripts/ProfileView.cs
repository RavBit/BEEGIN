using System.Collections;
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

    [SerializeField] private Button _buttonAccept;
    [SerializeField] private Button _buttonDecline;


    public void Initialize(Item[] items, string profession, string pun, bool isOwner, Profile profile)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (i > 5)
                break;
            
            _pieces[i].Initialize(items[i].sprite, items[i].title, items[i].description);
        }

        _buttonAccept.gameObject.SetActive(!isOwner);
        _buttonDecline.gameObject.SetActive(!isOwner);

        _labelProfession.text = profession;
        _labelPun.text = pun;
        _buttonClose.onClick.AddListener(OnButtonClicked);
        _imageCrown.gameObject.SetActive(isOwner);

        _buttonAccept.onClick.AddListener(profile.Groetjes);
        _buttonAccept.onClick.AddListener(Dispose);

        _buttonDecline.onClick.AddListener(profile.FijneAvond);
        _buttonDecline.onClick.AddListener(Dispose);
    }


    private void OnButtonClicked()
    {
        Dispose();
    }

    private void Dispose()
    {
        _buttonClose.onClick.RemoveListener(OnButtonClicked);
        _buttonAccept.onClick.RemoveAllListeners();
        _buttonDecline.onClick.RemoveAllListeners();
        transform.DOMoveX(1620, 0.3f);

        View.instance.SetHeader("My hive");
    }
}