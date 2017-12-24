using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInCircles : MonoBehaviour {

    public float RotateSpeed = 5f;
    public float Radius = 0.1f;
    public GameObject target;

    private Vector2 _centre;
    private float _angle;

    private void Start()
    {
        if (target)
        {
            _centre = target.transform.position; 
        }
        else
        {
            _centre = transform.position;
        }
        
    }

    private void FixedUpdate()
    {

        _angle += RotateSpeed * Time.deltaTime;

        var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;

        if (target)
        {
            _centre = target.transform.position;
        }
        transform.position = _centre + offset;
    }

   
}
