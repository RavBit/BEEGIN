using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileView : MonoBehaviour
{
    [SerializeField] private Piece[] _pieces;
    [SerializeField] private Text _labelProfession;
    

    public void Initialize(Item[] items, string profession)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (i > 5)
                break;
            
            _pieces[i].Initialize(items[i].sprite, items[i].title, items[i].description);
        }

        _labelProfession.text = profession;
    }
}