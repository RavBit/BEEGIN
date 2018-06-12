using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Interface_Manager : MonoBehaviour {
    [Header("Toolbar Components")]
    public Transform Toolbar;
    public Transform Menubar;
    public Transform[] Hexagons;
    public Transform Menu_Background;
    [Range(0, 1)]
    [SerializeField]
    private float ToolbarSpeed = 0.5f;
    private bool toggled = false;

    public int i = 0;
	// Use this for initialization
	void Start () {
        Menu_Background.GetComponent<Image>().DOFade(0, 0.01F);

    }


    public void OnToggle()
    {
        toggled = !toggled;
        if(toggled)
        {
            Menubar.DORotate(new Vector3(0, 0, 90), 1);
            Menu_Background.GetComponent<Image>().DOFade(1, 1F);
            Toolbar.DOMoveX(-250, 1);
        }
        if (!toggled)
        {
            Menubar.DORotate(Vector3.zero, 1);
            Menu_Background.GetComponent<Image>().DOFade(0, 1F);
            Toolbar.DOMoveX(-1000, 1);
        }
    }
}
