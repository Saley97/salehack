namespace Models
{
    [System.Serializable]
    public enum UserStatus
    {
        Admin,
        Staff,
        Parent,
        Child
    }

    [System.Serializable]
    public enum MessageType
    {
        MsgCamp,
        MsgSession,
        MsgSquad,
        MsgQuest,
        MsgPost,
        MsgUser,
        MsgPhoto,
        MsgBroadcast
    }
}