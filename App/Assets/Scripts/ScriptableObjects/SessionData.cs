using Models;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "SessionData", menuName = "ScriptableObjects/SessionData", order = 0)]
public class SessionData : ScriptableObject
{
    [SerializeField] private User currentUser;
    [SerializeField] private Camp currentCamp;
    [SerializeField] private Session currentSession;
    [SerializeField] private Squad currentSquad;
    [SerializeField] private Quest currentQuest;
    [SerializeField] private Post currentPost;
    [SerializeField] private Broadcast currentBroadcast;
    [SerializeField] private Photo currentPhoto;

    [SerializeField] private List<Quest> allQuests;
    [SerializeField] private List<Post> allPosts;

    public User CurrentUser
    {
        get => currentUser;
        set => currentUser = value;
    }

    public Camp CurrentCamp
    {
        get => currentCamp;
        set => currentCamp = value;
    }

    public Session CurrentSession
    {
        get => currentSession;
        set => currentSession = value;
    }

    public Squad CurrentSquad
    {
        get => currentSquad;
        set => currentSquad = value;
    }

    public Quest CurrentQuest
    {
        get => currentQuest;
        set => currentQuest = value;
    }

    public Post CurrentPost
    {
        get => currentPost;
        set => currentPost = value;
    }

    public Broadcast CurrentBroadcast
    {
        get => currentBroadcast;
        set => currentBroadcast = value;
    }

    public Photo CurrentPhoto
    {
        get => currentPhoto;
        set => currentPhoto = value;
    }

    public List<Post> AllPosts
    {
        get => allPosts;
        set => allPosts = value;
    }

    public List<Quest> AllQuests
    {
        get => allQuests;
        set => allQuests = value;
    }
}