using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public int TweetNum =0;

    [SerializeField] Text tweetNumtxt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tweetNumtxt.text = "ツイート数:" + TweetNum + "ツイート"; 
    }
}
