using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialoguecon : MonoBehaviour
{
    public Text dialogueText;
    public Button continueButton;
    public Button exitButton;
    public GameObject dialoguePanel;

    private Queue<string> dialogueQueue;

    void Start()
    {
        
        dialogueQueue = new Queue<string>();
        continueButton.onClick.AddListener(ShowNextDialogue);
        exitButton.onClick.AddListener(ExitDialogue);

        // 添加一些对话到队列
        EnqueueDialogue("陶文：如月，我的父母是不会来了…");
        EnqueueDialogue("司仪：吉时到！十三少如月两姓联姻");
        EnqueueDialogue("司仪：一堂缔约，仅以白头之约，书向鸿笺");
        EnqueueDialogue("司仪：夫妻对拜，礼成，交换信物……");
        // ... 添加更多对话
        
        exitButton.gameObject.SetActive(false);
        dialoguePanel.SetActive(false);
    }

    void EnqueueDialogue(string text)
    {
        dialogueQueue.Enqueue(text);
    }

    void ShowNextDialogue()
    {
        if (dialogueQueue.Count > 0)
        {
            string nextDialogue = dialogueQueue.Dequeue();
            dialogueText.text = nextDialogue;
        }
        else
        {
            // 对话结束时显示退出按钮
            continueButton.gameObject.SetActive(false);
            exitButton.gameObject.SetActive(true);
        }
    }

    void ExitDialogue()
    {
        // 关闭对话界面
        dialoguePanel.SetActive(false);
    }
}

