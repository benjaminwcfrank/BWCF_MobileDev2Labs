using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class LifeCounter : MonoBehaviour
{
    [Header("Life Properties")]
    public int value;

    private Image lifeImg;

    private void Start()
    {
        lifeImg = GetComponent<Image>();
        ResetLives();
    }

    public void ResetLives()
    {
        value = 3;
        lifeImg.sprite = Resources.Load<Sprite>("Sprites/Life3");

    }

    public void LoseLife()
    {
        value -= 1;
        if (value <= 0)
        {
            value = 0;
            SceneManager.LoadScene("End"); //putting this here since checking every tick for a changed var isn't too great.
        }


        lifeImg.sprite = Resources.Load<Sprite>($"Sprites/Life{value}");

    }

    public void GainLife()
    {
        value += 1;
        if (value > 3)
            value = 3;

        lifeImg.sprite = Resources.Load<Sprite>($"Sprites/Life{value}");

    }

}
