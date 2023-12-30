using UnityEngine;

public class Peoplecon : MonoBehaviour
{
    private Animator animator;
    private bool iswalk = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 获取玩家输入
        float verticalInput = Input.GetAxis("Vertical");

        // 判断是否按下"W"键
        if (verticalInput > 0)
        {
            // 切换到走路动画
            SetWalking(true);
        }
        else
        {
            // 切换到待机动画
            SetWalking(false);
        }
    }

    void SetWalking(bool walking)
    {
        // 如果当前状态与目标状态不一致，则进行切换
        if (iswalk != walking)
        {
            iswalk = walking;

            // 更新Animator中的"IsWalking"参数，该参数用于控制动画状态机的过渡
            animator.SetBool("iswalk", iswalk);
        }
    }
}