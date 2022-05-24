using CommandPattern.WithPattern.Interfaces;

namespace CommandPattern.WithPattern;

public record Order(string ProductName, int Quantity) : IMessage;