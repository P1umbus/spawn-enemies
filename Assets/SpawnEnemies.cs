using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private float _cooldownSpawn;

    private int _currentPoint;
    private Transform[] _points;
    private float _elapsed≈ime;

    private void Start()
    {
        _points = new Transform[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            _points[i] = transform.GetChild(i);
        }
    }

    private void Update()
    {
        if (_elapsed≈ime >= _cooldownSpawn)
        {
            GameObject newObject = Instantiate(_template, _points[_currentPoint].position, Quaternion.identity);
            _currentPoint++;

            if (_currentPoint >= _points.Length)
                _currentPoint = 0;

            _elapsed≈ime = 0;
        }
        _elapsed≈ime += Time.deltaTime;
    }
}
