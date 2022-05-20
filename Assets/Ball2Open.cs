using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2Open : MonoBehaviour
{
    public SpriteRenderer topSprite;
    void Start()
    {

    }
    public void Ball3Opens()
    {
        PlayerPrefs.SetString("AktifBall", "Ball3");
        var sprite = Resources.Load<Sprite>("Ball 3/aqua");
        topSprite.sprite = sprite;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
