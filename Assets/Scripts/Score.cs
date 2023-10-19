using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public class Points: MonoBehaviour
    {
        public static int Point;
    }

    public Text ValueText;
    private void Start()
    {
        ValueText.text = Points.Point.ToString();
    }

    private void Update()
    {
        ValueText.text = Points.Point.ToString();

    }


}
