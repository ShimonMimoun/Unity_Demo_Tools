using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CollisionDelayLaser :KeyboardSpawner {

    [SerializeField] NumberField scoreField;

    [Tooltip("Delay for Laser")]  [SerializeField] float delay = 1.0f;
    private bool check = false;
    private float flag;

    protected override GameObject spawnObject()
    {
        GameObject newObject = base.spawnObject();  // base = super

        // Modify the text field of the new object.
        ScoreAdder newObjectScoreAdder = newObject.GetComponent<ScoreAdder>();
        if (newObjectScoreAdder)
            newObjectScoreAdder.SetScoreField(scoreField);

        return newObject;
    }

    private void Reset()
    {
        if (check && flag > 0)
        {
            flag -= Time.deltaTime;
        }
        if (flag < 0)
        {
            flag = 0;
            check = false;
        }
    }
    private void  Update()
    {
        Reset();

        if (Input.GetKeyDown(keyToPress) && !check)
        {

            flag = delay;
            check = true;
            base.spawnObject();
        }
    }
}
