using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollEgg : MonoBehaviour
{
    public float rollForce = 1f;
    public float delay = 10f; // Delay before force is applied

    // Start is called before the first frame update
    void Start()
    {// Start the coroutine to apply force after a delay
        StartCoroutine(ApplyForceAfterDelay());
    }

    IEnumerator ApplyForceAfterDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);
    }


    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector3(0.5f, 0f, 0f) * rollForce);
        //transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime);

    }
}
