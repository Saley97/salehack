using Newtonsoft.Json;

namespace Models
{
    [System.Serializable]
    public class MessageBase
    {
        public MessageType type;
        public int requestStatus;
        public string serialisedData;

        protected MessageBase(string data)
        {
            serialisedData = data;
        }

        public string GetSerializedMessage()
        {
            return JsonConvert.SerializeObject(this);
        }

        public virtual BaseModel GetObject()
        {
            return JsonConvert.DeserializeObject<BaseModel>(serialisedData);
        }
    }

    public class MessageCamp : MessageBase
    {
        public MessageCamp(string data) : base(data)
        {
            this.type = MessageType.MsgCamp;
        }

        public override BaseModel GetObject()
        {
            return base.GetObject() as Camp;
        }
    }
    
    public class MessageSession : MessageBase
    {
        public MessageSession(string data) : base(data)
        {
            this.type = MessageType.MsgSession;
        }
        
        public override BaseModel GetObject()
        {
            return JsonConvert.DeserializeObject<Session>(serialisedData);
        }
    }
    
    public class MessageSquad : MessageBase
    {
        public MessageSquad(string data) : base(data)
        {
            this.type = MessageType.MsgSquad;
        }
        
        public override BaseModel GetObject()
        {
            return JsonConvert.DeserializeObject<Squad>(serialisedData);
        }
    }
    
    public class MessageQuest : MessageBase
    {
        public MessageQuest(string data) : base(data)
        {
            this.type = MessageType.MsgQuest;
        }
        
        public override BaseModel GetObject()
        {
            return JsonConvert.DeserializeObject<Quest>(serialisedData);
        }
    }
    
    public class MessagePost : MessageBase
    {
        public MessagePost(string data) : base(data)
        {
            this.type = MessageType.MsgPost;
        }
        
        public override BaseModel GetObject()
        {
            return JsonConvert.DeserializeObject<Post>(serialisedData);
        }
    }
    
    public class MessageBroadcast : MessageBase
    {
        public MessageBroadcast(string data) : base(data)
        {
            this.type = MessageType.MsgBroadcast;
        }
        
        public override BaseModel GetObject()
        {
            return JsonConvert.DeserializeObject<Broadcast>(serialisedData);
        }
    }
    public class MessageUser : MessageBase
    {
        public MessageUser(string data) : base(data)
        {
            this.type = MessageType.MsgUser;
        }
        
        public override BaseModel GetObject()
        {
            return JsonConvert.DeserializeObject<User>(serialisedData);
        }
    }
    
    public class MessagePhoto : MessageBase
    {
        public MessagePhoto(string data) : base(data)
        {
            this.type = MessageType.MsgPhoto;
        }
        
        public override BaseModel GetObject()
        {
            return JsonConvert.DeserializeObject<Photo>(serialisedData);
        }
    }
}