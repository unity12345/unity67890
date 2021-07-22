using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 弾オブジェクト
    public GameObject bulletPrefab;
    // Canvasオブジェクト
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        // Canvasオブジェクト
        canvas = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update() {

        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-0.01f, 0, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(0.01f, 0, 0);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0, 0.01f, 0);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0, -0.01f, 0);
        }
        // スペースキー押下時の処理
        if(Input.GetKeyDown(KeyCode.Space)){
            // 発射した弾の数をカウントアップ
            canvas.GetComponent<BulletCount>().AddCount();
            // 弾を複製
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}
