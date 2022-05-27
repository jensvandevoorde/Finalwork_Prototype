using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 30;

        /* gAnm = gallade.GetComponent<Animator>().runtimeAnimatorController;
         DontDestroyOnLoad(gallade);
         GameObject g1 = Instantiate(gallade, new Vector3(0.09f, 0.84f, posZ), transform.rotation);

         var anC = g1.GetComponent<Animator>();
         anC.runtimeAnimatorController = gAnm; */

        // lAnm = lucario.GetComponent<Animator>().runtimeAnimatorController;
        // DontDestroyOnLoad(lucario);
        //GameObject l1 = Instantiate(lucario, new Vector3(0.09f, 0.84f, posZ), Quaternion.identity);

        // var anC = l1.GetComponent<Animator>();
        // anC.runtimeAnimatorController = lAnm;


    }


    // Update is called once per frame
    void Update()
    {
        /*  isMoving = true;
          if (isMoving)
          {
              timePassed += Time.deltaTime;
              AnimateGallade();
          }*/
    }

    /* void AnimateGallade()
     {
         if (maxSize > transform.localScale.x)
         {
             gallade.transform.localScale += new Vector3(1f, 1f, 1f) * Time.deltaTime * growFactor;
         }
         if (timePassed < totalTime)
         {
             float percentagePassed = timePassed / totalTime;
             gallade.transform.position = Vector3.Lerp(startPos, destinationPos, percentagePassed);

         }
         else
         {
             transform.position = destinationPos;
             isMoving = false;
         }
     }*/


}
