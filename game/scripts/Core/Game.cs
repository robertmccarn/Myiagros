using Godot;

namespace Myiagros.Core;

public partial class Game : Node
{
    public override void _Ready()
    {
        GD.Print("Myiagros initialized.");
    }
}
