using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBallSelect : MonoBehaviour
{
    public SpriteRenderer topSprite;
    void Start()
    {

    }
    public void Ball3Opens()
    {
        PlayerPrefs.SetString("AktifBall", "FirstBall");
        var sprite = Resources.Load<Sprite>("Ball First/orange");
        topSprite.sprite = sprite;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
