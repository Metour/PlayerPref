using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    public Text nameText;
    public Text scoreText;
    public Text positionText;

    public string userName;
    public int userScore;
    public Vector3 userPosition;

    // Start is called before the first frame update
    void Start()
    {
        LoadData();
    }

    void LoadData()
    {
        nameText.text = "User Name: " + PlayerPrefs.GetString("name", "No Name");
        scoreText.text = "User Score: " + PlayerPrefs.GetInt("score", 0).ToString();
        positionText.text = "User Position: " + PlayerPrefs.GetFloat("posX", 0).ToString() + "x " + PlayerPrefs.GetFloat("posY", 0).ToString() + "y " + PlayerPrefs.GetFloat("posZ", 0).ToString() + "z ";
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("name", userName);
        PlayerPrefs.SetInt("score", userScore);
        PlayerPrefs.SetFloat("posX", userPosition.x);
        PlayerPrefs.SetFloat("posY", userPosition.y);
        PlayerPrefs.SetFloat("posZ", userPosition.z);

        LoadData();
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("name");
        PlayerPrefs.DeleteKey("score");
        PlayerPrefs.DeleteKey("PosX");
        PlayerPrefs.DeleteKey("PosY");
        PlayerPrefs.DeleteKey("PosZ");

        //Lo borra todo
        PlayerPrefs.DeleteAll();

        LoadData();
    }
}
