using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    
    private GameObject gameOverText;
    private GameObject runLengthText;

    //floatのlen（走った距離）
    private float len = 0;

    //floatのspeed（走る速度）
    private float speed = 5f;

    //boolでゲームオーバー判定
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        this.gameOverText = GameObject.Find("GameOver");
        this.runLengthText = GameObject.Find("RunLength");
    }

    // Update is called once per frame
    void Update()
    {
        if  (this.isGameOver == false)
		{
            this.len += this.speed * Time.deltaTime;
            this.runLengthText.GetComponent<Text>().text = "Distance:  " + len.ToString("F2") + "m";
        }


        if (this.isGameOver == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }


    }

    public void GameOver()
	{
        this.gameOverText.GetComponent<Text>().text = "Game Over";
        this.isGameOver = true;
    }

}