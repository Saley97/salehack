using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Models;
using Newtonsoft.Json;
using Proyecto26;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField] private bool isFlag = false;
    [SerializeField] private WebConfig config;
    [SerializeField] private Sprite testSprite;
    [SerializeField] private Image img;

    [SerializeField] private bool imgFlag = false;
    
    


    private User testUser = new User()
    {
        id = 666,
        login = "MyLogin",
        name = "MyName",
        passwd = "qwerty12",
        uStatus = UserStatus.Child
    };

    private void Start()
    {
        foreach (var header in RestClient.DefaultRequestHeaders)
        {
            Debug.Log(header.Key + " ============= " + header.Value);
        }
    }

    private void Update()
    {
//        if (isFlag)
//        {
//            Debug.Log("User data:");
//            Debug.Log(testUser.GetJson());
//            MessageUser msgSend = new MessageUser(testUser.GetJson());
//            Debug.Log("Message Sended:");
//            Debug.Log(msgSend.GetSerializedMessage());
//
//            MessageUser msgGet = JsonConvert.DeserializeObject<MessageUser>(msgSend.GetSerializedMessage());
//            Debug.Log("Message Geted:");
//            Debug.Log(msgGet?.GetSerializedMessage());
//
//            User getedUser = msgGet.GetObject() as User;
//            Debug.Log("Geted user data:");
//            Debug.Log(getedUser.GetJson());
//            
//            isFlag = false;
//        }

        if (isFlag)
        {
//            RestClient.Get(config.ServerPath).Then(response =>
//            {
//                Debug.Log(/*JsonConvert.DeserializeObject<MessageUser>*/(response.Text));
//            }).Catch(error =>
//            {
//                Debug.Log(error.Message);
//            });
//
//            isFlag = false;
            //MessageUser msgSend = new MessageUser(testUser.GetJson());
            
            MessagePhoto msgPhoto = new MessagePhoto(
                new Photo()
                {
                    id = 6,
                    width = testSprite.texture.width,
                    height = testSprite.texture.height,
                    format = testSprite.texture.format,
                    mipmapCount = testSprite.texture.mipmapCount,
                    //texture = testSprite.texture,
                    data = testSprite.texture.GetRawTextureData()
                }.GetJson());
            
            RestClient.Request(
                new RequestHelper(){
                    Uri = config.ServerPath,  
                    Method = "POST", 
                    Timeout = 100,
                    //Body = msgPhoto,
                    BodyString = msgPhoto.GetSerializedMessage(),
                    //Body = testUser,
                    DownloadHandler = new DownloadHandlerFile(Application.dataPath + "/test.json") //Send bytes directly if it's required  DownloadHandler = new DownloadHandlerFile(destPah)
                }
                ).Then(response =>
            {
                Debug.Log("Success");
                imgFlag = true;
            }).Catch(error =>
            {
                Debug.Log(error.Message);
            });

            isFlag = false;
        }

        if (imgFlag)
        {
            MessagePhoto rMsg = JsonConvert.DeserializeObject<MessagePhoto>(File.ReadAllText(Application.dataPath + "/test.json")) as MessagePhoto;
            Photo photo = rMsg.GetObject() as Photo;
            Texture2D texture = new Texture2D(photo.width, photo.height, photo.format, photo.mipmapCount > 1);
            texture.LoadRawTextureData(photo.data);
            //texture.Apply();
            Debug.Log(photo.data.Length);
            //Debug.Log(ImageConversion.LoadImage(texture, rPhoto.data, false));
            texture.Apply();
            img.sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);

            imgFlag = false;
        }
    }
}
