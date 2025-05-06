using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTransitcation : MonoBehaviour
{
    public Image displayImage; // G�r�nt�lenecek resim alan�
    public Sprite[] images; // Resim dizisi
    private int currentIndex = 0;

    void Start()
    {
        UpdateImage();
    }

    public void NextImage()
    {
        if (images.Length == 0) return;
        currentIndex = (currentIndex + 1) % images.Length; // Sonraki resmi g�ster
        UpdateImage();
    }

    public void PreviousImage()
    {
        if (images.Length == 0) return;
        currentIndex = (currentIndex - 1 + images.Length) % images.Length; // �nceki resmi g�ster
        UpdateImage();
    }

    private void UpdateImage()
    {
        displayImage.sprite = images[currentIndex]; // Resmi g�ncelle
    }

}
