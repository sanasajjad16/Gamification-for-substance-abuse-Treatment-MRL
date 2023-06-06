using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasController : MonoBehaviour
{
    public TextMeshProUGUI pointsText;

    void Start()
    {
        pointsText.text = "Points: " + GameManager.points;
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "Points: " + GameManager.points;
    }
}
