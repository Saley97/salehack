using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Models;
using UnityEngine.UI;

public class FeedView : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private Image img;

    private Post postInfo;

    public void FillView(Post post)
    {
        postInfo = post;
        text.text = post.text;

        Photo photo = post.photo;

        if (photo == null)
        {
            return;
        }

        /*Texture2D texture = new Texture2D(photo.width, photo.height, photo.format, photo.mipmapCount > 1);
        texture.LoadRawTextureData(photo.data);
        texture.Apply();

        img.sprite = Sprite.Create(
            texture, 
            new Rect(0.0f, 0.0f, texture.width, texture.height), 
            new Vector2(0.5f, 0.5f), 100f
            );*/
    }
}
