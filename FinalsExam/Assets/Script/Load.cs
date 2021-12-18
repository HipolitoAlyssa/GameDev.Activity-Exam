using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public Text FullBox;
    // Start is called before the first frame update
    void Start()
    {
        FullBox.text = PlayerPrefs.GetString("full");
    }
    
    public void clickreset()
    {
        PlayerPrefs.DeleteKey("full");
        SceneManager.LoadScene("1stScene");
    }
}
