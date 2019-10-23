using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyView : MonoBehaviour
{
    [SerializeField] private GameObject contentHolder;
    [SerializeField] private GameObject contentPrefab;
    [SerializeField] private BodyState bodyContent;

    public SessionData SessionData { get; set; }

    public void FillBody()
    {
        switch (bodyContent)
        {
            case BodyState.Feed:
                FillFeed();
                break;
            case BodyState.Quest:
                FillQuest();
                break;
            case BodyState.Profile:
                break;
        }
    }

    private void FillFeed()
    {
        /*foreach (var item in contentHolder.transform.GetComponentsInChildren<Transform>())
        {
            if (!item.CompareTag("Finish"))
            {
                Debug.Log(item.gameObject.name);
                Destroy(item.gameObject);
            }
        }
        contentHolder.GetComponent<VerticalLayoutGroup>().childControlHeight = false;
        foreach (var quest in SessionData.AllQuests)
        {
            GameObject instans = Instantiate(contentPrefab, contentHolder.transform);
            QuestView instanceView = instans.GetComponent<QuestView>();
            instanceView.FillView(quest);
        }
        contentHolder.GetComponent<VerticalLayoutGroup>().childControlHeight = true;*/
    }

    private void FillQuest()
    {
        /*foreach (var item in contentHolder.transform.GetComponentsInChildren<Transform>())
        {
            if (!item.CompareTag("Finish"))
            {
                Destroy(item.gameObject);
            }
        }
        contentHolder.GetComponent<VerticalLayoutGroup>().childControlHeight = false;
        foreach (var quest in SessionData.AllQuests)
        {
            GameObject instans = Instantiate(contentPrefab, contentHolder.transform);
            QuestView instanceView = instans.GetComponent<QuestView>();
            instanceView.FillView(quest);
        }
        contentHolder.GetComponent<VerticalLayoutGroup>().childControlHeight = true;*/
    }
}
