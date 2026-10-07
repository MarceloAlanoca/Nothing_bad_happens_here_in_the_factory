namespace Nothing_bad_happens_here_in_the_factory;

public static class InputManager
{
    private static Vector2 _direction;
    public static Vector2 Direction => _direction;
    public static bool Moving => _direction != Vector2.Zero;

    public static void Update()
    {
        _direction = Vector2.Zero;
        var KeyboardState = Keyboard.GetState();

        if(KeyboardState.GetPressedKeyCount() > 0)
        {
            if(KeyboardState.IsKeyDown(Keys.A)) _direction.X--;
            if(KeyboardState.IsKeyDown(Keys.A)) _direction.X++;
        }
    }
}