using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball1Open : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer topSprite;
    void Start()
    {
        
    }
    public void Ball1Opens()
    {
        PlayerPrefs.SetString("AktifBall","Ball2");
        var sprite = Resources.Load<Sprite>("Ball 2/football");
        topSprite.sprite = sprite;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
