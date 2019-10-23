using System;
using Newtonsoft.Json;
using UnityEngine;

namespace Models
{
    [System.Serializable]
    public class BaseModel
    {
        public int id;

        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    
    [System.Serializable]
    public class Camp : BaseModel
    {
        public string name;
        public string description;
        public Session[] sessions;
    }

    [System.Serializable]
    public class Session : BaseModel
    {
        public string name;
        public string description;
        public DateTime startDate;
        public DateTime endDate;
        public Broadcast broadcast;
        public Squad[] squads;
    }
    
    [System.Serializable]
    public class Squad : BaseModel
    {
        public string name;
        public int minAge;
        public int maxAge;
        public User[] kids;
        public User[] staff;
        public Quest[] quests;
        public Post[] posts;
    }
    
    [System.Serializable]
    public class Quest : BaseModel
    {
        public string name;
        public string task;
        public DateTime startDate;
        public int duration;
    }
    
    [System.Serializable]
    public class Post : BaseModel
    {
        public Photo photo;
        public string text;
        public User author;
        public DateTime date;
        public bool status;
    }
    
    [System.Serializable]
    public class Broadcast : BaseModel
    {
        public string url;
    }
    
    [System.Serializable]
    public class User : BaseModel
    {
        public string login;
        public string name;
        public string passwd;
        public UserStatus uStatus;
    }
    
    [System.Serializable]
    public class Photo : BaseModel
    {
        public int width;
        public int height;
        public TextureFormat format;
        public int mipmapCount;
        public byte[] data;
    }
}