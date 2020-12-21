using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //変数定義
    //キューブの移動速度
    private float speed = -12;
    //消滅位置
    private float deadLine = -10;



    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0); //毎フレームspeed * フレームレート補正

        //画面外に出たら破壊する
        if (transform.position.x < this.deadLine)
		{
            Destroy(gameObject);
		}
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collider");
        audioSource = gameObject.GetComponent<AudioSource>();
        if (collision.gameObject.tag == "Sound")
        {
        audioSource.Play();
        }
    }
}