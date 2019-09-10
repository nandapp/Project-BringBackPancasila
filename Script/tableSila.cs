using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tableSila : MonoBehaviour {

    public static int collSila = 0;

    public Text text;
    public AudioClip silaAdd;

    public Image UI_1;
    public Image UI_2;
    public Image UI_3;
    public Image UI_4;
    public Image UI_5;

    public GameObject sila1;
    public GameObject sila2;
    public GameObject sila3;
    public GameObject sila4;
    public GameObject sila5;

    public GameObject bintang;
    public GameObject rantai;
    public GameObject pohon;
    public GameObject banteng;
    public GameObject padikapas;

    public void tsSila1()
    {
        if (sila1 == null)
        {
            bintang.SetActive(true);
            collSila = collSila + 1;
            GetComponent<AudioSource>().PlayOneShot(silaAdd);
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
        if (sila2 == null)
        {
            rantai.SetActive(true);
            collSila = collSila + 1;
            GetComponent<AudioSource>().PlayOneShot(silaAdd);
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
            GetComponent<AudioSource>().PlayOneShot(silaAdd);
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
        if (sila4 == null)
        {
            banteng.SetActive(true);
            collSila = collSila + 1;
            GetComponent<AudioSource>().PlayOneShot(silaAdd);
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
        if (sila5 == null)
        {
            padikapas.SetActive(true);
            collSila = collSila + 1;
            GetComponent<AudioSource>().PlayOneShot(silaAdd);
        }
        else
        {
            text.text = "Temukan lambang sila kelima Pancasila";
            Invoke("DisableText", 3f);
            Debug.Log("Cari dulu padi & kapas nya");
        }
    }

    // Use this for initialization
    void Start ()
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
    void Update ()
    {
        if (sila1 == null)
            UI_1.enabled = false;
        if (sila2 == null)
            UI_2.enabled = false;
        if (GameObject.Find("3_Persatuan(Clone)") == null)
            UI_3.enabled = false;
        if (sila4 == null)
            UI_4.enabled = false;
        if (sila5 == null)
            UI_5.enabled = false;
    }
}
