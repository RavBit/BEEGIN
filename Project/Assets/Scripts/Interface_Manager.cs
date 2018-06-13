using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Interface_Manager : MonoBehaviour {
    [Header("Toolbar Components")]
    public Transform Toolbar;
    public Transform Menubar;
    public Transform[] Hexagons;
    public Transform Menu_Background;
    public GameObject[] SubMenus;
    public Text Label;

    public GameObject Settingsscreen;

    public ProfileView ProfileView;

    [Header("Settings and stuff screen")]
    public GameObject Bug_Report;
    [Range(0, 1)]
    [SerializeField]
    private float ToolbarSpeed = 0.5f;
    private bool toggled = false;
    private bool IfMyHive = false;
    public int i = 0;
	// Use this for initialization
	void Start () {
        Menu_Background.GetComponent<Image>().DOFade(0, 0.01F);
        Menu_Background.gameObject.SetActive(false);

    }

    public void DisposeScreen()
    {
        ProfileView.Dispose();
    }

    public void HoneyInTheMaking()
    {
        Debug.Log("Honey in the making");
        Label.text = "Honey in the Making";
        View.instance.SetHeader("Honey in the Making");
    }

    public void MyHive()
    {
        Label.text = "My Hive";
        View.instance.SetHeader("My Hive");
        IfMyHive = true;
    }

    public void OnToggle()
    {
        Handheld.Vibrate();
        toggled = !toggled;
        if(toggled)
        {
            Menu_Background.gameObject.SetActive(true);
            Menubar.DORotate(new Vector3(0, 0, 90), 1);
            Menu_Background.GetComponent<Image>().DOFade(1, 1F);
            if (IfMyHive)
            {
                Toolbar.DOMoveX(0, 1);
                return;
            }
            Toolbar.DOMoveX(-250, 1);
        }
        if (!toggled)
        {
            Menu_Background.gameObject.SetActive(false);
            Menubar.DORotate(Vector3.zero, 1);
            Menu_Background.GetComponent<Image>().DOFade(0, 1F);
            Toolbar.DOMoveX(-1000, 1);
        }
    }

    public void SubMenu(int i)
    {
        Handheld.Vibrate();
        SubMenus[i].SetActive(!SubMenus[i].activeInHierarchy);
    }

    public void ReportBug()
    {
        Handheld.Vibrate();
        OnToggle();
        Bug_Report.SetActive(true);
        Bug_Report.transform.DOLocalMoveX(0, 1);
    }

    public void SendBug()
    {
        Handheld.Vibrate();
        Bug_Report.transform.DOLocalMoveX(1080, 1);
        Invoke("DeactiveBug", 1);
    }

    public void DeactiveBug()
    {
        Handheld.Vibrate();
        Bug_Report.SetActive(false);
    }

    public void LogOut()
    {
        Handheld.Vibrate();
        SceneManager.LoadScene("Login");
    }

    public void Tutorial()
    {
        Handheld.Vibrate();
        SceneManager.LoadScene("Tutorial");
    }

    public void SettingsTrigger()
    {
        Handheld.Vibrate();
        OnToggle();
        Settingsscreen.SetActive(true);
        Settingsscreen.transform.DOLocalMoveX(0, 1);
    }

    public void SettingsExit()
    {
        Handheld.Vibrate();
        Settingsscreen.transform.DOLocalMoveX(1080, 1);
        Invoke("DeactivateSetting", 1);
    }

    public void DeactivateSetting()
    {
        Handheld.Vibrate();
        Settingsscreen.SetActive(false);
    }
}
