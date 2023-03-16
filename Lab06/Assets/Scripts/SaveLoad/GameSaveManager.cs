using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSaveManager : MonoBehaviour
{
    public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        //Setup of player done when instantiating player prefab
    }



    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            //load
            LoadData();
        }

        if(Input.GetKeyDown(KeyCode.J))
        {
            //save
            SaveData();
        }
    }

    private void SaveData()
    {
        Debug.Log("Saving data");
        SaveDataPlayerPrefs();






    }

    private void SaveDataPlayerPrefs()
    {
        var positionString = JsonUtility.ToJson(player.position);
        var rotationString = JsonUtility.ToJson(player.localEulerAngles);

        PlayerPrefs.SetString("playerPosition", positionString);
        PlayerPrefs.SetString("playerRotation", rotationString);

        PlayerPrefs.Save();
    }

    private void LoadDataPlayerPrefs()
    {
        var position = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("playerPosition"));
        var rotation = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("playerRotation"));

        player.gameObject.GetComponent<CharacterController>().enabled = false;

        player.position = position;
        player.rotation = Quaternion.Euler(rotation.x, rotation.y, rotation.z);

        player.gameObject.GetComponent<CharacterController>().enabled = true;
    }

    private void LoadData()
    {
        Debug.Log("Loading data");
        LoadDataPlayerPrefs();
    }

    private void ResetData()
    {
        Debug.Log("Removed data");

        PlayerPrefs.DeleteAll();
    }

    public void OnSaveButtonPressed()
    {
        SaveData();
    }

    public void OnLoadButtonPressed()
    {
        LoadData();
    }
}
