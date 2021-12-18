using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public InputField textBox;

    public void clickPlay()
    {
        PlayerPrefs.SetString("full", textBox.text);
        SceneManager.LoadScene("2ndScene");
    }
}
