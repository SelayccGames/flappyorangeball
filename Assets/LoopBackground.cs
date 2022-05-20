using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBackground : MonoBehaviour
{
    public Transform cameraTransform;
    private Vector3 lastcameraPosition;
    private float textureUnitSizeX;
    public float parallax;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastcameraPosition = cameraTransform.position;
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;
        textureUnitSizeX = texture.width / sprite.pixelsPerUnit;

    }
    private void LateUpdate()
    {
        Vector3 deltaMovement=cameraTransform.position - lastcameraPosition;
        transform.position += deltaMovement*parallax;
        lastcameraPosition=cameraTransform.position;
        if(Mathf.Abs( cameraTransform.position.x-transform.position.x)>=textureUnitSizeX)


        {
            float offsetPosx = (cameraTransform.position.x - transform.position.x*2) % textureUnitSizeX;
            transform.position = new Vector3(cameraTransform.position.x-offsetPosx, transform.position.y);
        }
    }

}
