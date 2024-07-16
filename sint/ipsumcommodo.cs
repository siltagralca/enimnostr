/// <summary>
/// The possible color schemes, corresponding to the light and dark appearances.
/// </summary>
public enum ColorScheme
{
    Light,
    Dark
}

// Usage example:
ColorScheme currentScheme = ColorScheme.Light;

switch (currentScheme)
{
    case ColorScheme.Light:
        Console.WriteLine("Using light color scheme");
        break;
    case ColorScheme.Dark:
        Console.WriteLine("Using dark color scheme");
        break;
}
