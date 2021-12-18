using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public Text NameBox;
    // Start is called before the first frame update
    void Start()
    {
        NameBox.text = PlayerPrefs.GetString("name");
    }

    public void clickReset()
    {
        PlayerPrefs.DeleteKey("name");
        SceneManager.LoadScene("F1Scene");

    }
}
