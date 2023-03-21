using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Block[] blocks;
    public GameObject gameOverUI;
    public GameObject gameClearUI;
    public GameObject BGM;
    public GameObject SE;

    private bool isGameClear = false;
    private AudioSource audioSource = null;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameClear != true)
        {
            if (DestoroyAllBlocks())
            {
                //ゲームクリア
                Debug.Log("ゲームクリア");
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

    //ブロックがすべて破壊されたかチェックするメソッド
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

    //ボールが下の壁に触れたかを確認するメソッド
    public void GameOver()
    {
        //ゲームオーバー
        Debug.Log("ゲームオーバー");
        gameOverUI.SetActive(true);

    }

    public void GameRetry()
    {
        SceneManager.LoadScene("game");
    }
}
