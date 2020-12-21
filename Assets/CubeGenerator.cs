using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    //変数定義系
    //キューブのPrefab
    public GameObject cubePrefab; //あとでアタッチするのでpublic
    //時間計測用の変数
    private float delta = 0;
    //キューブの生成間隔
    private float span = 1.0f;
    //キューブの生成位置(X座標)(横)
    private float genPosX = 12;

    //キューブの生成位置（縦方向）オフセット
    private float offsetY = 0.3f;
    //キューブの縦方向の間隔
    private float spaceY = 6.9f;

    //キューブの生成位置（横方向）オフセット
    private float offsetX = 0.5f;
    //キューブの横方向の感覚
    private float spaceX = 0.4f;

    //キューブの上向きの生成個数の上限
    private int maxBlockNum = 4;
       

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;　//deltaは秒数

        //span（生成間隔）秒以上の時間が経過したかを調べる
        if (this.delta > this.span)
		{
            this.delta = 0; //deltaを0に戻す

            //生成するキューブ数をランダムに決める
            int n = Random.Range(1, maxBlockNum + 1); //1からmaxBlockNumまでの乱数

            //nで指定した数だけキューブを生成
            for (int i =0; i < n; i++)
			{
                GameObject go = Instantiate(cubePrefab) as GameObject;
                go.transform.position = new Vector2(this.genPosX, this.offsetY + i * this.spaceY);
			}
            this.span = this.offsetX + this.spaceX * n; //0.5 + 0.4(1~4)
		}
    }
}
