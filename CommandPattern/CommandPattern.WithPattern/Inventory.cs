using CommandPattern.WithPattern.Interfaces;

namespace CommandPattern.WithPattern;

public record Inventory(string ProductName, int Quantity) : IMessage;