using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletCount : MonoBehaviour
{
    // 弾の数
    int count = 0;
    // 弾の数テキスト
    GameObject bulletCount;

    // 発射した弾の数を+1
    public void AddCount(){
    	this.count += 1;
    }

    void Start() {
        // 弾の数テキストを取得
        this.bulletCount = GameObject.Find("BulletCount");
    }

    void Update() {
        // 5桁ゼロ埋めでテキスト表示
        bulletCount.GetComponent<Text>().text = "発射した弾の数：" + this.count.ToString("D5");
    }
}