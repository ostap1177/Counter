using UnityEngine;
using UnityEngine.Events;

public class ClickHandler : MonoBehaviour
{
    private bool _isButtonDown;

    public event UnityAction<bool> ButtonPressed;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isButtonDown = !_isButtonDown;
            ButtonPressed?.Invoke(_isButtonDown);
        }
    }
}
