using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CountdownTimer
{
    public class CountdownTimer : MonoBehaviour
    {
        Text textComponent;
        [SerializeField] float timeRemaining = 3;
        [SerializeField] bool isCountingDown = false;

        void Start()
        {
            isCountingDown = true;
            textComponent = gameObject.GetComponent<Text>();
            textComponent.text = timeRemaining.ToString("F0") + "...";
        }

        void Update()
        {
            if (isCountingDown)
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                    textComponent.text = timeRemaining.ToString("F0") + "...";
                }
                else
                {
                    textComponent.text = "GO!";
                    timeRemaining = 0;
                    isCountingDown = false;
                }
            }
        }
    }
}