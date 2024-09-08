using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float rotateAmont = 300.0f;
    [SerializeField]float velocityAmont = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float velocidade = Input.GetAxis("Vertical") * velocityAmont * Time.deltaTime;
        float rotacao = Input.GetAxis("Horizontal") * rotateAmont * Time.deltaTime;

        transform.Rotate(0, 0, -rotacao);
        transform.Translate(0, velocidade, 0);
    }
}
