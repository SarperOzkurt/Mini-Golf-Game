using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupController : MonoBehaviour
{
    private bool ballInCup;

    public GameObject inCupEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (ballInCup == false)
            {
                ballInCup = true;

                Debug.Log("Ball In Cup!");

                ShotController.instance.SetInCup();


                HoleController.instance.BallInCup();

                inCupEffect.SetActive(true);

                AudioManager.instance.PlaySFX(2);
            }
        }
    }
}
