using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    int _speed = 1;
    [SerializeField]
    UnityEngine.UI.Text _speedText;

    void Update()
    {
        ChangeSpeed();

        transform.Rotate(Vector3.up, 45*Time.deltaTime*_speed);
    }

    void ChangeSpeed()
    {
        bool up = Input.GetKeyDown(KeyCode.UpArrow);
        bool down = Input.GetKeyDown(KeyCode.DownArrow);

        if (up)
        {
            _speed += 1;
            _speedText.text = _speed.ToString();
        }

        if (down)
        {
            _speed -= 1;
            _speedText.text = _speed.ToString();
        }
    }
}
