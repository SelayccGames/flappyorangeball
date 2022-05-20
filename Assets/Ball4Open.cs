using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball4Open : MonoBehaviour
{
    public SpriteRenderer topSprite;
    void Start()
    {

    }
    public void Ball3Opens()
    {
        PlayerPrefs.SetString("AktifBall", "Ball5");
        var sprite = Resources.Load<Sprite>("Ball 5/lemon");
        topSprite.sprite = sprite;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
