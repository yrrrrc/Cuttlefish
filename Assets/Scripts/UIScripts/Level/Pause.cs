using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour 
{ 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GamePause()
    {
        GameObject.Find("GameMainControl").GetComponent<GameMainControl>().isPause = true;//��ͣ
        Time.timeScale = 0f;
    }
}
