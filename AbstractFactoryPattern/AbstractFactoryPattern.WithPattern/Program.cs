using AbstractFactoryPattern.WithPattern.Implementations.Factory;

var macOs = new MacOsUiControlsFactory();
macOs.GetAlertBox();
macOs.GetButton();

var linux = new LinuxUiControlsFactory();
linux.GetAlertBox();
linux.GetButton();

var windows = new WindowsUiControlsFactory();
windows.GetAlertBox();
windows.GetButton();