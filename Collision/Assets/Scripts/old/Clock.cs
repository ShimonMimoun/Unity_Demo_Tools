using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    [SerializeField] int ticks = 0;
    [SerializeField] Text textField;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Tick());
    }

    IEnumerator Tick() {
        while (true) {
            ticks++;
            textField.text = ticks.ToString();
            yield return new WaitForSeconds(1);
        }
    }
}
