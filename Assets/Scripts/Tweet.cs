using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tweet : MonoBehaviour
{

    [SerializeField] GameObject tweet;

    [SerializeField] GameObject Parent;

    [SerializeField] Text tweetNum;

    [SerializeField] ScrollRect tweetber;

    List<GameObject> Tweets = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int tweetsnum = Tweets.Count;

        tweetNum.text = "ツイート数:" + tweetsnum + "ツイート";
    }


    public void OnClickTweetButton()
    {

        Tweets.Add(Instantiate( tweet,new Vector3(0,0,0),Quaternion.identity,Parent.transform ));

      

        tweetber.verticalNormalizedPosition = 1.1f;

        
    }
}
