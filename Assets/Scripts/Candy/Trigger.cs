using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public GameObject Candy;

    [SerializeField] private UnityEvent TriggerEnter1;


    private void OnTriggerEnter2D(Collider2D other)
    {
        TriggerEnter1.Invoke();
        Destroy(Candy);
        Score.Points.Point = Score.Points.Point + 1;
        Debug.Log(Score.Points.Point);
    }
}
