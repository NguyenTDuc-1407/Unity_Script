using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    Transform playerMover;
    // Start is called before the first frame update
    void Start()
    {
        playerMover = gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        playerMover.Translate(0, 0, 4 * Time.deltaTime);
    }
}
