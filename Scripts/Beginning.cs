using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beginning : MonoBehaviour
{
    public float maxSize;
    public float growFactor;
    Vector3 startPos;
    Vector3 destinationPos;
    public float totalTime = 2f;
    float timePassed;
    bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        destinationPos = new Vector3(0, startPos.y, startPos.z);
    }

    // Update is called once per frame
    void Update()
    {
        isMoving = true;
        if (isMoving)
        {
            timePassed += Time.deltaTime;
            AnimateGallade();
        }
    }

    void AnimateGallade()
    {
        if (maxSize > transform.localScale.x)
        {
            transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
        }
        if (timePassed < totalTime)
        {
            float percentagePassed = timePassed / totalTime;
            transform.position = Vector3.Lerp(startPos, destinationPos, percentagePassed);

        }
        else
        {
            transform.position = destinationPos;
            isMoving = false;
        }
    }
}
