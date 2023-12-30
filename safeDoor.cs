using UnityEngine;

public class safeDoor : MonoBehaviour
{
    public delegate void DoorClickedEvent();
    public static event DoorClickedEvent OnDoorClicked;
    public void OpenDoor()
    {
        transform.Rotate(new Vector3(0, 0, -90));
    }

    public void CloseDoor()
    {
        
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