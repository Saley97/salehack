using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraTest : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private Image image;
    
    void Update()
    {
        if( Input.GetMouseButtonDown( 0 ) )
        {
            // Don't attempt to use the camera if it is already open
            if( NativeCamera.IsCameraBusy() )
                return;
			
            TakePicture(512);
        }
    }

    private void TakePicture( int maxSize )
    {
        NativeCamera.Permission permission = NativeCamera.TakePicture( ( path ) =>
        {
            Debug.Log( "Image path: " + path );
            text.text = "Image path: " + path;
            if( path != null )
            {
                // Create a Texture2D from the captured image
                Texture2D tex = NativeCamera.LoadImageAtPath( path, maxSize );
                if( tex == null )
                {
                    Debug.Log( "Couldn't load texture from " + path );
                    return;
                }

                NativeGallery.SaveImageToGallery(tex, "GalleryTest", "My img {0}.png");
                
                Sprite mySprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
                image.sprite = mySprite;
            }
        }, maxSize );

        Debug.Log( "Permission result: " + permission );
        text.text += "\n Permission result:" + permission;
    }

}
