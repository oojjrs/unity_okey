using UnityEngine;

public class MyKeyPool : MonoBehaviour
{
    [SerializeField]
    private MyKeyPoolGamepad _gamepad;
    [SerializeField]
    private MyKeyPoolKeyboard _keyboard;
    [SerializeField]
    private MyKeyPoolMouse _mouse;

    public Sprite GetSprite(string key)
    {
        return default;
    }
}
