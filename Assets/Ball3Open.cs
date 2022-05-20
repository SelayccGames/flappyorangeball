using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball3Open : MonoBehaviour
{
    public SpriteRenderer topSprite;
    void Start()
    {

    }
    public void Ball3Opens()
    {
        PlayerPrefs.SetString("AktifBall", "Ball4");
        var sprite = Resources.Load<Sprite>("Ball 4/tomato");
        topSprite.sprite = sprite;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
