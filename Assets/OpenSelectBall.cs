using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSelectBall : MonoBehaviour
{
    // Start is called before the first frame update
    public string selectedBall;
    public SpriteRenderer topSprite;
    void Start()
    {

        if (PlayerPrefs.HasKey("AktifBall"))
        {
            selectedBall = PlayerPrefs.GetString("AktifBall");
            if(selectedBall=="Ball2")
            {
                var sprite = Resources.Load<Sprite>("Ball 2/football");
                topSprite.sprite = sprite;
            }
            if (selectedBall == "Ball3")
            {
                var sprite = Resources.Load<Sprite>("Ball 3/aqua");
                topSprite.sprite = sprite;
            }
            if (selectedBall == "Ball4")
            {
                var sprite = Resources.Load<Sprite>("Ball 4/tomato");
                topSprite.sprite = sprite;
            }
            if (selectedBall == "Ball5")
            {
                var sprite = Resources.Load<Sprite>("Ball 5/lemon");
                topSprite.sprite = sprite;
            }
        }
        else
        {
            var sprite = Resources.Load<Sprite>("Ball First/orange");
            topSprite.sprite = sprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
