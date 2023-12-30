using UnityEngine;
using UnityEngine.UI;

public class choutpaper : MonoBehaviour
{
    public GameObject uiPanel; // 关联UI面板
    public Button closeButton; // 关联关闭按钮

    void Start()
    {
        // 隐藏UI面板初始状态
        uiPanel.SetActive(false);

        // 添加关闭按钮的点击事件
        closeButton.onClick.AddListener(CloseUIPanel);
    }

    void Update()
    {
        // 检测鼠标左键点击
        if (Input.GetMouseButtonDown(0))
        {
            // 获取鼠标点击的位置
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // 如果点击到了纸条对象
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                // 显示UI面板
                ShowUIPanel();
            }
        }
    }

    void ShowUIPanel()
    {
        // 显示UI面板
        uiPanel.SetActive(true);
    }

    void CloseUIPanel()
    {
        // 关闭UI面板
        uiPanel.SetActive(false);
    }
}