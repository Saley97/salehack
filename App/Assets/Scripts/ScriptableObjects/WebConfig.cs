using UnityEngine;

[CreateAssetMenu(fileName = "WebConfig", menuName = "ScriptableObjects/WebConfig", order = 0)]
public class WebConfig : ScriptableObject
{
    [SerializeField] private string protocol;
    [SerializeField] private string serverUrl;
    [SerializeField] private string port;
    [SerializeField] private string localPath;

    private string serverPath;

    public string ServerPath
    {
        get
        {
            string res = protocol + "://" + serverUrl + ":" + port + "/" + localPath;
            return res;
        }
        private set => serverPath = value;
    }
}