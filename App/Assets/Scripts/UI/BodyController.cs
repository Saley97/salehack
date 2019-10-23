using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyController : MonoBehaviour
{
    [SerializeField] private CanvasGroup feedBody;
    [SerializeField] private CanvasGroup questBody;
    [SerializeField] private CanvasGroup profileBody;

    [SerializeField] private RequestController requestController;

    private bool isCanShow = false;
    private BodyState bodyState = BodyState.Feed;

    public bool IsCanShow
    {
        get => isCanShow;
        set => isCanShow = value;
    }

    private void Start()
    {
        StartCoroutine(LoadBody());
    }

    public void ShowFeed()
    {
        SwitchBody(BodyState.Feed);
    }

    public void ShowQuest()
    {
        SwitchBody(BodyState.Quest);
    }

    public void ShowProfile()
    {
        SwitchBody(BodyState.Profile);
    }

    private void SwitchBody(BodyState state)
    {
        if (state == bodyState || !isCanShow)
        {
            Debug.Log("HI");
            return;
        }

        bodyState = state;
        isCanShow = false;

        OffCanvas(feedBody);
        OffCanvas(questBody);
        OffCanvas(profileBody);

        StartCoroutine(LoadBody());
    }

    private IEnumerator LoadBody()
    {
        requestController.RequestPlaceholder(); // TODO
        while (!isCanShow)
        {
            yield return null;
        }

        if (bodyState == BodyState.Feed)
            OnCanvas(feedBody);
        if (bodyState == BodyState.Quest)
            OnCanvas(questBody);
        if (bodyState == BodyState.Profile)
            OnCanvas(profileBody);
    }

    private void OffCanvas(CanvasGroup canvas)
    {
        canvas.alpha = 0f;
        canvas.blocksRaycasts = false;
    }

    private void OnCanvas(CanvasGroup canvas)
    {
        BodyView view = canvas.GetComponent<BodyView>();
        view.SessionData = requestController.SessionData;
        view.FillBody();

        canvas.alpha = 1f;
        canvas.blocksRaycasts = true;
    }
}
