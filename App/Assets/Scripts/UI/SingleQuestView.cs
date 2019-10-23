using Michsky.UI.ModernUIPack;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleQuestView : MonoBehaviour
{
    private ModalWindowManager modalWindowManager;

    private void Start()
    {
        modalWindowManager = FindObjectOfType<ModalWindowManager>();
    }

    public void ClickAction()
    {
        modalWindowManager.OpenWindow();
    }
}
