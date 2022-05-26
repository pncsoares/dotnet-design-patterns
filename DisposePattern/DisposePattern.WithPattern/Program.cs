using DisposePattern.WithPattern;

using var serviceProxy = new ServiceProxy(null);

serviceProxy.Get();
serviceProxy.Post("");