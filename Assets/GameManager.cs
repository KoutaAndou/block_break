using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Block[] blocks;
    public GameObject gameOverUI;
    public GameObject gameClearUI;

    private bool isGameClear = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameClear != true)
        {
            if (DestoroyAllBlocks())
            {
                //�Q�[���N���A
                Debug.Log("�Q�[���N���A");
                GameObject[] objects = GameObject.FindGameObjectsWithTag("Ball");
                foreach (GameObject g in objects)
                {
                    Destroy(g);
                }
                gameClearUI.SetActive(true);
                isGameClear = true;
            }
        }
    }

    //�u���b�N�����ׂĔj�󂳂ꂽ���`�F�b�N���郁�\�b�h
    private bool DestoroyAllBlocks()
    {
        foreach(Block b in blocks)
        {
            if (b != null)
            {
                return false;
            }
        }
        return true;
    }

    //�{�[�������̕ǂɐG�ꂽ�����m�F���郁�\�b�h
    public void GameOver()
    {
        //�Q�[���I�[�o�[
        Debug.Log("�Q�[���I�[�o�[");
        gameOverUI.SetActive(true);

    }

    public void GameRetry()
    {
        SceneManager.LoadScene("game");
    }


}
