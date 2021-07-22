using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    void Start() {
    }

    void Update() {
        // 弾が画面外に出た場合にオブジェクトを破棄
        transform.Translate(0, 0.015f, 0);
        if(transform.position.y > 5){
            Destroy(gameObject);
        }
    }
}
