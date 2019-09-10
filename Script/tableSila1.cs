using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tableSila1 : MonoBehaviour
{

    public static int collSila = 0;

    public Text text;

    public Image UI_1;
    public Image UI_2;
    public Image UI_3;
    public Image UI_4;
    public Image UI_5;

    public GameObject bintang;
    public GameObject rantai;
    public GameObject pohon;
    public GameObject banteng;
    public GameObject padikapas;

    public void tsSila1()
    {
        if (GameObject.Find("1_Ketuhanan") == null)
        {
            bintang.SetActive(true);
            collSila = collSila + 1;
        }
        else
        {
            text.text = "Temukan lambang sila pertama Pancasila";
            Invoke("DisableText", 3f);
            Debug.Log("Cari dulu bintangnya");
        }
    }

    public void tsSila2()
    {
        if (GameObject.Find("2_Kemanusiaan") == null)
        {
            rantai.SetActive(true);
            collSila = collSila + 1;
        }
        else
        {
            text.text = "Temukan lambang sila kedua Pancasila";
            Invoke("DisableText", 3f);
            Debug.Log("Cari dulu rantainya");
        }
    }

    public void tsSila3()
    {
        if (GameObject.Find("3_Persatuan(Clone)") == null)
        {
            pohon.SetActive(true);
            collSila = collSila + 1;
        }
        else
        {
            text.text = "Temukan lambang sila ketiga Pancasila";
            Invoke("DisableText", 3f);
            Debug.Log("Cari dulu pohon nya");
        }
    }

    public void tsSila4()
    {
        if (GameObject.Find("4_Kerakyatan") == null)
        {
            banteng.SetActive(true);
            collSila = collSila + 1;
        }
        else
        {
            text.text = "Temukan lambang sila keempat Pancasila";
            Invoke("DisableText", 3f);
            Debug.Log("Cari dulu banteng nya");
        }
    }

    public void tsSila5()
    {
        if (GameObject.Find("5_Keadilan") == null)
        {
            padikapas.SetActive(true);
            collSila = collSila + 1;
        }
        else
        {
            text.text = "Temukan lambang sila kelima Pancasila";
            Invoke("DisableText", 3f);
            Debug.Log("Cari dulu padi & kapas nya");
        }
    }

    // Use this for initialization
    void Start()
    {
        bintang.SetActive(false);
        rantai.SetActive(false);
        pohon.SetActive(false);
        banteng.SetActive(false);
        padikapas.SetActive(false);
    }

    void DisableText()
    {
        text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("1_Ketuhanan") == null)
            UI_1.enabled = false;
        if (GameObject.Find("2_Kemanusiaan") == null)
            UI_2.enabled = false;
        if (GameObject.Find("3_Persatuan(Clone)") == null)
            UI_3.enabled = false;
        if (GameObject.Find("4_Kerakyatan") == null)
            UI_4.enabled = false;
        if (GameObject.Find("5_Keadilan") == null)
            UI_5.enabled = false;
    }
}
