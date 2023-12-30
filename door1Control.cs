using UnityEngine;

public class door1Control : MonoBehaviour
{
    public delegate void DoorClickedEvent();
    public static event DoorClickedEvent OnDoorClicked;
    public void OpenDoor()
    {
        transform.Rotate(new Vector3(0, 90, 0));
    }

    public void CloseDoor()
    {
        // 实现门关闭的逻辑
        // 例如：transform.Rotate(new Vector3(0, -90, 0));
    }
    private void OnMouseDown()
    {
        // 当门被点击时触发事件
        if (OnDoorClicked != null)
        {
            OnDoorClicked();
        }
    }
}