using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class Login : MonoBehaviour {
    public GameObject RegisterScreen;
    public void LoginUser()
    {
        Handheld.Vibrate();
        SceneManager.LoadScene("Tutorial");
    }

    public void Register()
    {
        RegisterScreen.SetActive(true);
        RegisterScreen.transform.DOLocalMoveX(0, 1);
    }

}
