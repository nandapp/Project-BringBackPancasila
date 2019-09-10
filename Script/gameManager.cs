using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;

    public Image UI;
    public Image UI_1;
    public Image UI_2;
    public Image UI_3;
    public Image UI_4;
    public Image UI_5;

    public GameObject spawnZombie;
    public GameObject spawnZ1;

    public GameObject MSG;

    private static int collSilaa;
    public Text text;

    public randomSpawner RS;
    public GameObject SILASISA;
    public GameObject texPancasila;
    public GameObject key;
    public GameObject key2;

    public GameObject S1;
    public GameObject S2;
    public GameObject S3;
    public GameObject S4;

    public GameObject TS1;
    public GameObject TS2;
    public GameObject TS3;
    public GameObject TS4;
    public GameObject TS5;

    public Light L1;
    public Light L2;
    public Light L3;
    public Light L4;
    public Light L5;
    public Light L6;
    public Light L7;
    public Light L8;
    public Light L9;

    public void gameMNG()
    {
        if (GameObject.FindGameObjectWithTag("Sila") == null)
        {
            audioSource.PlayOneShot(sound1);
            SILASISA.SetActive(true);
            S1.SetActive(true);
            S2.SetActive(true);
            S3.SetActive(true);
            S4.SetActive(true);
            RS.calls();
            Debug.Log("Anda harus mencari 5 sila");
            text.text = "Temukan 5 lambang sila dari masing-masing sila";
            Invoke("DisableText", 5f);

            TS1.SetActive(true);
            TS2.SetActive(true);
            TS3.SetActive(true);
            TS4.SetActive(true);
            TS5.SetActive(true);

            UI.enabled = true;
            UI_1.enabled = true;
            UI_2.enabled = true;
            UI_3.enabled = true;
            UI_4.enabled = true;
            UI_5.enabled = true;
        }
        else
        {
            finishSila();
        }
    }

    public void finishSila()
    {
        if (collSilaa < 5)
        {
            audioSource.PlayOneShot(sound2);
            Debug.Log("anda harus mengumpulkan kelima sila" + collSilaa);
            text.text = "Anda belum mengumpulkan kelima sila";
            Invoke("DisableText", 3f);
        }
        else if (collSilaa >= 5)
        {
            audioSource.PlayOneShot(sound3);
            text.text = "Dengan kembalinya 5 sila Pancasila, keragaman budaya di indonesia telah lengkap";
            Invoke("DisableText", 3f);
            L1.enabled = true;
            L2.enabled = true;
            L3.enabled = true;
            L4.enabled = true;
            L5.enabled = true;
            L6.enabled = true;
            L7.enabled = true;
            L8.enabled = true;
            L9.enabled = true;

            MSG.SetActive(true);
            UI.enabled = false;

            spawnZombie.SetActive(true);
            spawnZ1.SetActive(true);

            texPancasila.SetActive(true);
            key.SetActive(true);
            Destroy(key2);

            Debug.Log("selamat anda berhasil mengumpulkan kelima sila");
        }
    }

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        collSilaa = 0;
        SILASISA.SetActive(false);
        texPancasila.SetActive(false);
        key.SetActive(false);
        spawnZombie.SetActive(false);
        spawnZ1.SetActive(false);
        MSG.SetActive(false);
        //UI_SILA.enabled = false;

        S1.SetActive(false);
        S2.SetActive(false);
        S3.SetActive(false);
        S4.SetActive(false);

        TS1.SetActive(false);
        TS2.SetActive(false);
        TS3.SetActive(false);
        TS4.SetActive(false);
        TS5.SetActive(false);

        L1.enabled = false;
        L2.enabled = false;
        L3.enabled = false;
        L4.enabled = false;
        L5.enabled = false;
        L6.enabled = false;
        L7.enabled = false;
        L8.enabled = false;
        L9.enabled = false;

        UI.enabled = false;
        UI_1.enabled = false;
        UI_2.enabled = false;
        UI_3.enabled = false;
        UI_4.enabled = false;
        UI_5.enabled = false;
    }

    void DisableText()
    {
        text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        collSilaa = tableSila.collSila;
    }
}
