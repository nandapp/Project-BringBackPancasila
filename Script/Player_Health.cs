using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player_Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth = 0;

    public Texture Tex1;
    public Texture Tex2;

    // Use this for initialization
    void Start ()
    {
        currentHealth = maxHealth;
	}

    public void TakeDamage(int _damage)
    {
        currentHealth -= _damage;

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene("GAME OVER");
        Debug.Log("GAME OVER !!");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void OnGUI()
    {
        if (currentHealth < 100 && currentHealth >= 50)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Tex1);
        }
        else if (currentHealth <= 0)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Tex2);
        }
    }

    // Update is called once per frame
    void Update () {
		
	} 
}
