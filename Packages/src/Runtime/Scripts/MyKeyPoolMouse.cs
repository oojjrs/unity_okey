using UnityEngine;

[CreateAssetMenu(fileName = nameof(MyKeyPoolMouse), menuName = "OKey/My Key Pool Mouse")]
public class MyKeyPoolMouse : ScriptableObject
{
    public Sprite Body;
    public Sprite Direction;
    public Sprite DirectionDown;
    public Sprite DirectionLeft;
    public Sprite DirectionRight;
    public Sprite DirectionUp;
    public Sprite LeftButton;
    public Sprite MiddleButton;
    public Sprite RightButton;
    public Sprite WheelDown;
    public Sprite WheelMove;
    public Sprite WheelUp;
}
