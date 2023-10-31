using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logix : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerscore;
    public Text scoreText;
    public GameObject gameoverscreen;


    [ContextMenu("Increase")]
    public void Addscore()
    {
        playerscore = playerscore + 1;
        scoreText.text = playerscore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameoverscreen.SetActive(true);
    }
}
