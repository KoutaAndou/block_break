using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //キーボードの左キーが押されたとき
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //プレイヤーの位置が左の壁よりも内側だったら
            if(this.transform.position.x > -4)
            {
                //プレイヤーを左に動かす
                this.transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }

        //キーボードの右キーが押されたとき
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //プレイヤーの位置が右の壁よりも内側だったら
            if (this.transform.position.x < 4)
            {
                //プレイヤーを右に動かす
                this.transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
    }
}
