using Models;
using System;
using UnityEngine;

namespace Michsky.UI.ModernUIPack
{
    public class ModalWindowManager : MonoBehaviour
    {
        [SerializeField] private RequestController requestController;

        private SessionData SessionData => requestController.SessionData;

        private Animator mwAnimator;

        private Texture2D texturePhoto;
        private string text;

        void Start()
        {
            mwAnimator = gameObject.GetComponent<Animator>();
        }

        public void OpenWindow()
        {
            mwAnimator.Play("Fade-in");
        }

        public void CloseWindow()
        {
            mwAnimator.Play("Fade-out");
        }

        public void CameraButtonAction()
        {
            if (NativeCamera.IsCameraBusy())
                return;

            TakePicture(1024);
        }

        public void EndEditTextAction(string newText)
        {
            text = newText;
        }

        public void EndEditPostAction()
        {
            Photo photo = null;
            if (texturePhoto != null)
            {
                photo = new Photo()
                {
                    id = 6,
                    width = texturePhoto.width,
                    height = texturePhoto.height,
                    format = texturePhoto.format,
                    mipmapCount = texturePhoto.mipmapCount,
                    data = texturePhoto.GetRawTextureData()
                };
            }
            Post post = new Post()
            {
                author = SessionData.CurrentUser,
                text = text,
                photo = photo,
                date = DateTime.Now,
                status = false,
                id = -1
            };
            requestController.SendPostRequest(post);
        }

        private void TakePicture(int maxSize)
        {
            NativeCamera.Permission permission = NativeCamera.TakePicture((path) =>
            {
                if (path != null)
                {
                    Texture2D tex = NativeCamera.LoadImageAtPath(path, maxSize);
                    if (tex == null)
                    {
                        Debug.Log("Couldn't load texture from " + path);
                        return;
                    }

                    NativeGallery.SaveImageToGallery(tex, "GalleryTest", "My img {0}.png");
                    texturePhoto = tex;
                }
            }, maxSize);
        }
    }
}