using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tweets : MonoBehaviour
{

    [SerializeField] GameObject[] tweet;

    [SerializeField] GameObject Parent;

   

    [SerializeField] ScrollRect tweetber;

    [SerializeField]List<GameObject> Tweet = new List<GameObject>();

    [SerializeField]GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }


    public void OnClickTweetButton()
    {

        int randnum = Random.Range(0, tweet.Length);
        Debug.Log(randnum + "番目を生成");
        if(Tweet.Count >= 5)
        {

            Destroy(Tweet[0]);

            Tweet.RemoveAt(0);


        }


        Tweet.Add(Instantiate( tweet[randnum],new Vector3(0,0,0),Quaternion.identity,Parent.transform ));

        gameManager.TweetNum += 1;

        tweetber.verticalNormalizedPosition = 1.1f;

        
    }
}
