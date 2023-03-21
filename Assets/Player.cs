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

        //�L�[�{�[�h�̍��L�[�������ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //�v���C���[�̈ʒu�����̕ǂ���������������
            if(this.transform.position.x > -4)
            {
                //�v���C���[�����ɓ�����
                this.transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }

        //�L�[�{�[�h�̉E�L�[�������ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //�v���C���[�̈ʒu���E�̕ǂ���������������
            if (this.transform.position.x < 4)
            {
                //�v���C���[���E�ɓ�����
                this.transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
    }
}
