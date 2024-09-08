using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float rotateAmont = 1.0f;
    [SerializeField]float velocityAmont = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float velocidade = Input.GetAxis("Vertical") * velocityAmont;
        float rotacao = Input.GetAxis("Horizontal") * rotateAmont;

        transform.Rotate(0, 0, -rotacao);
        transform.Translate(0, velocidade, 0);
    }
}
