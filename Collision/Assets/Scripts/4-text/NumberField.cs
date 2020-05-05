using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
public class NumberField : MonoBehaviour {
    private TextMeshPro textField;
    private int number;
    void Start()    {
        textField = GetComponent<TextMeshPro>();
        if (!textField)
            throw new MissingComponentException("Object must contain a TextMeshPro field!");
    }

    public int GetNumber() {
        return this.number;
    }

    public void SetNumber(int newNumber) {
        this.number = newNumber;
        this.textField.text = newNumber.ToString();
    }
}
