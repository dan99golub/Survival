﻿using UnityEngine;

public abstract class InputService : IInputService
{
    protected const string Horizontal = "Horizontal";
    protected const string Vertical = "Vertical";
    protected const string Fire = "Fire";

    public abstract Vector2 Axis { get; }

    public bool IsAttackButtonUp() =>
       SimpleInput.GetButtonUp(Fire);

    protected Vector2 SimpeInputAxis() =>
         new Vector2(SimpleInput.GetAxis(Horizontal), SimpleInput.GetAxis(Vertical));
}
