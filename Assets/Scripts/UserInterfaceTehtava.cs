using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class UserInterfaceTehtava : MonoBehaviour
{
    public TextMeshProUGUI HealthText;
    public TextMeshProUGUI AliveText;
    public Image Sprite;
    int health = 100;

    public TextMeshProUGUI LukuText;
    public TextMeshProUGUI MassitText;
    public TextMeshProUGUI OnkoVaraaText;
    int Massit = 100;
    int Hinta = 5;
    int Luku = 0;

    public Image RGBImage;
    public Image RGBImage_1;
    public Slider R_Slider;
    public Slider G_Slider;
    public Slider B_Slider;
    float R = 255f;
    float G = 255f;
    float B = 255f;
    public void UpdateColor()
    {
        R = (R_Slider.value);
        G = (G_Slider.value);
        B = (B_Slider.value);
        RGBImage.color = new Color(R, G, B);
        RGBImage_1.color = new Color(R, G, B);
    }
    public void Osta()
    {
        if(Massit >= Hinta)
        {
            Massit -= Hinta;
            Luku += 1;
            MassitText.text = Massit.ToString() + "€";
            LukuText.text = Luku.ToString();
        }else
        {
            OnkoVaraaText.text = "Ei ole varaa";
        }
    }
    public void Nappi()
    {   
        if (health > 0)
        {
        health -= 10;
        updateHealth();
        }
    }
    public void updateHealth()
    {
        HealthText.text = health.ToString();
        if (health <= 0) {
        AliveText.text = "Kuollut";
        }
    }
    public void increaseSpriteSize()
    {
        if (Sprite.rectTransform.localScale.y < 4) {
        Sprite.rectTransform.localScale *= 2;
        }
    }
    public void decreaseSpriteSize()
    {
        if (Sprite.rectTransform.localScale.y > 0.25)
        {
            Sprite.rectTransform.localScale /= 2;
        }
    }
}
