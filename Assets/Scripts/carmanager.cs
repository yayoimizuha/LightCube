using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmanager : MonoBehaviour
{
    public int vec;
    public float maxspeed = 5;
    private int forcem = 1;
    private Vector2 force;
    private Rigidbody2D _rb;
    Vector2[] vector = {new Vector2(1f,0f),new Vector2(-1f,0f),new Vector2(0f,1f),new Vector2(0f,-1f)};
    public void Initialize(int vec)
    {
        this.vec = vec;
    }
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        force = forcem * vector[vec];
    }

    void FixedUpdate()
    {
        // TODO: 車に力を与える仕組みを完成させる
        // TODO: 最大速度になったら加速を止める
        if (_rb.velocity.magnitude < maxspeed)
        {
            _rb.AddForce(force);
        }
        // TODO: 前方に車があるときに停車する
        // TODO: 赤信号のときに停車する
        // TODO: 停車中は1秒おきに1点の減点処理を行う
        // TODO: 横方向からの車の衝突時は車のデータを削除する
        // TODO: 衝突時は100点の減点処理を行う
    }
}
