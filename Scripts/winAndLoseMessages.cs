using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winAndLoseMessages : MonoBehaviour
{
    public Text message;
    public GameObject shadowWall;
    float xPos;
    float yPos;
    float zPos;
    float timer;
    bool canRemoveShadow = false;
    bool canPlaceShadow = false;
    float percentagePassed;
    Vector3 startPos;
    Vector3 destinationPos;

    void Update()
    {
        if (canRemoveShadow)
        {
            RemoveShadow();
        }
        if (canPlaceShadow)
        {
            CastShadow();
        }

    }
    void RemoveShadow()
    {
        xPos = -0.49f;
        yPos = 5.3167f;
        zPos = 3.56f;
        timer += Time.deltaTime;
        percentagePassed = timer / 2f;

        startPos = new Vector3(xPos, yPos, zPos);
        destinationPos = new Vector3(xPos, yPos + 8f, zPos);
        shadowWall.transform.position = Vector3.Lerp(startPos, destinationPos, percentagePassed);
        canPlaceShadow = true;

    }

    void CastShadow()
    {
        xPos = -0.49f;
        yPos = 5.3167f;
        zPos = 3.56f;
        timer += Time.deltaTime;
        percentagePassed = timer / 8f;

        startPos = new Vector3(xPos, yPos + 8, zPos);
        destinationPos = new Vector3(xPos, yPos, zPos);
        shadowWall.transform.position = Vector3.Lerp(startPos, destinationPos, percentagePassed);
    }
    public void Right(string text)
    {
        message.text = text;
        canRemoveShadow = true;


    }

    public void Wrong(string text)
    {
        message.text = text;
        canRemoveShadow = true;
    }

}
