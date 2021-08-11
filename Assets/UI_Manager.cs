using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Text R_var;

    public Text G_var;

    public Text B_var;

    public Slider Slider;

    public Image Image;

    Renderer Renderer;

    void Awake()
    {
    }

    public void GetImage(Image Img)
    {
        Renderer = null;
        Image = Img;
        Color clr = Image.color;
        Color32 color32 = clr;
        R_var.text = color32.r.ToString();
        G_var.text = color32.g.ToString();
        B_var.text = color32.b.ToString();
        Slider.value = clr.g;
    }

    public void GetRenderer(Renderer Render)
    {
        Image = null;
        Renderer = Render;
        Material cubeMaterial = Renderer.material;
        Color32 color32 = cubeMaterial.color;
        R_var.text = color32.r.ToString();
        G_var.text = color32.g.ToString();
        B_var.text = color32.b.ToString();
        Slider.value = cubeMaterial.color.g;
    }

    public void Button_Random()
    {
        if (Image != null)
        {
            Color32 clr32 = Image.color;
            int i = Random.Range(0, 255);
            clr32[2] = (byte) i;
            Image.color = clr32;
            B_var.text = clr32.b.ToString();
        }

        if (Renderer != null)
        {
            Color32 color32 = Renderer.material.color;
            int i = Random.Range(0, 255);
            color32[2] = (byte) i;
            Renderer.material.color = color32;
            B_var.text = color32.b.ToString();
        }
    }

    public void Button_Slider()
    {
        if (Image != null)
        {
            Color newColor = Image.color;
            newColor.g = Slider.value;
            Image.color = newColor;
            Color32 clr32 = Image.color;
            G_var.text = clr32.g.ToString();
        }

        if (Renderer != null)
        {
            Color newColor = Renderer.material.color;
            newColor.g = Slider.value;
            Renderer.material.color = newColor;
            Color32 clr32 = Renderer.material.color;
            G_var.text = clr32.g.ToString();
        }
    }

    public void Button_Pus()
    {
        if (Image != null)
        {
            Color32 clr32 = Image.color;
            int i = clr32[0];
            i++;
            clr32[0] = (byte) i;
            Image.color = clr32;
            R_var.text = clr32.r.ToString();
            Invoke("Button_Pus", 0.3f);
        }
        if (Renderer != null)
        {
            Color32 clr32 = Renderer.material.color;
            int i = clr32[0];
            i++;
            clr32[0] = (byte) i;
            Renderer.material.color = clr32;
            R_var.text = clr32.r.ToString();
            Invoke("Button_Pus", 0.3f);
        }
    }

    public void Button_Minus()
    {
        if (Image != null)
        {
            Color32 clr32 = Image.color;
            int i = clr32[0];
            i--;
            clr32[0] = (byte) i;
            Image.color = clr32;
            R_var.text = clr32.r.ToString();
            Invoke("Button_Minus", 0.3f);
        }

        if (Renderer != null)
        {
            Color32 clr32 = Renderer.material.color;
            int i = clr32[0];
            i--;
            clr32[0] = (byte) i;
            Renderer.material.color = clr32;
            R_var.text = clr32.r.ToString();
            Invoke("Button_Pus", 0.3f);
        }
    }

    public void Button_Stop()
    {
        CancelInvoke();
    }
}
