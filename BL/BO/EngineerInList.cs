﻿ namespace BO;
public class EngineerInList
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public override string ToString() => this.ToStringProperty();
}