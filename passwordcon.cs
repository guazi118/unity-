using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class passwordcon : MonoBehaviour
{
    public GameObject uiPanel;
    public Button[] btn;
    private string _password;
    public Text _Text;
    public InputField _Field;
    public door1Control doorController;
    private void Start()
    {
        uiPanel.SetActive(false);
        door1Control.OnDoorClicked += OnDoorClicked;
        btn[0].onClick.AddListener(btn_00);
        btn[1].onClick.AddListener(btn_01);
        btn[2].onClick.AddListener(btn_02);
        btn[3].onClick.AddListener(btn_03);
        btn[4].onClick.AddListener(btn_04);
        btn[5].onClick.AddListener(btn_05);
        btn[6].onClick.AddListener(btn_06);
        btn[7].onClick.AddListener(btn_07);
        btn[8].onClick.AddListener(btn_08);
        btn[9].onClick.AddListener(btn_09);
        btn[10].onClick.AddListener(btn_clear);
        btn[11].onClick.AddListener(btn_login);
        btn[12].onClick.AddListener(btn_exit);
    }
    private void OnDestroy()
    {
        // 取消订阅DoorController的事件，以防止内存泄漏
        door1Control.OnDoorClicked -= OnDoorClicked;
    }
    private void OnDoorClicked()
    {
        // 当门被点击时显示UI界面
        uiPanel.SetActive(true);
    }
    private void Update()
    {
        _Field.text = _password;
    }

    private void btn_00()
    {
        _password += "0";
    }
    private void btn_01()
    {
        _password += "1";
    }
    private void btn_02()
    {
        _password += "2";
    }
    private void btn_03()
    {
        _password += "3";
    }
    private void btn_04()
    {
        _password += "4";
    }
    private void btn_05()
    {
        _password += "5";
    }
    private void btn_06()
    {
        _password += "6";
    }
    private void btn_07()
    {
        _password += "7";
    }
    private void btn_08()
    {
        _password += "8";
    }
    private void btn_09()
    {
        _password += "9";
    }
    private void btn_clear()
    {
        _password = "";
    }
    private void btn_login()
    {
        if (_password=="44776")
        {
            doorController.OpenDoor();
            uiPanel.SetActive(false);
        }
        else
        {
            _Text.text = "密码错误";
            _password = "";

        }
    }

    private void btn_exit()
    {
        uiPanel.SetActive(false);
    }
}
