using UnityEngine;

public class ChoutiControl : MonoBehaviour
{
    private Vector3 initialPosition;
    private Vector3 openPosition;
    private bool isOpen = false;
    public float slideSpeed = 5f; // 调整抽屉的打开速度

    void Start()
    {
        initialPosition = transform.position;
        openPosition = initialPosition + new Vector3(0f, 0f, 0.3f); // 调整抽屉打开的距离
    }

    void Update()
    {
        // 检测鼠标左键点击
        if (Input.GetMouseButtonDown(0))
        {
            // 获取鼠标点击的位置
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // 如果点击到了抽屉对象
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                // 切换抽屉状态
                ToggleDrawer();
            }
        }

        // 平滑移动抽屉
        if (isOpen)
        {
            transform.position = Vector3.Lerp(transform.position, openPosition, Time.deltaTime * slideSpeed);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, initialPosition, Time.deltaTime * slideSpeed);
        }
    }

    void ToggleDrawer()
    {
        isOpen = !isOpen;
    }
}
