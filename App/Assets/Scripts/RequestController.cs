using Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestController : MonoBehaviour
{
    [SerializeField] private SessionData sessionData;
    [SerializeField] private BodyController bodyController;

    public SessionData SessionData
    {
        get => sessionData;
        set => sessionData = value;
    }

    public void RequestPlaceholder()
    {
        bodyController.IsCanShow = true;
    }

    public void SendPostRequest(Post post)
    {
        MessagePost msg = new MessagePost(post.GetJson());
        msg.requestStatus = 0;
        //TODO send
        SessionData.AllPosts.Add(post);
    }
}
