# C# Windows Forms RS232 Terminal

This is a simple RS232 terminal application built using C# and Windows Forms. It provides a graphical user interface (GUI) for sending and receiving data over a serial port.

## Features

- Connect to a serial port
- Send data to the connected device
- Receive data from the connected device
- Configure serial port settings (baud rate, data bits, parity, stop bits)
- Ping round trip delay with time measure
- Flow control. Note that during tests some of the features didn't work

## Prerequisites

To run this application, you need the following:

- Windows operating system
- .NET Framework installed

## Getting Started

Follow these steps to get started with the RS232 terminal:

1. Clone or download this repository to your local machine.
2. Open the solution file (`RS232Terminal.sln`) in Visual Studio or any other C# IDE.
3. Build the solution to compile the application.

## GUI

![image](https://github.com/my-memory-leaked/RS232-Terminal/assets/72348855/eb76d3ca-a11a-45ca-a676-220ac83145e8)

## Usage

1. Launch the RS232 terminal application.
3. Select the desired serial port from the drop-down menu.
4. Set the appropriate serial port settings (baud rate, data bits, parity, stop bits) using the provided options.
5. Click on the "Open" button to open the selected serial port.
6. Use the text box labeled "Send command" to enter the data you want to send to the connected device.
7. Click on the "Send" button to send the entered data to the device.
8. The received data from the device will be displayed in the text box.

## Connection:

![image](https://github.com/my-memory-leaked/RS232-Terminal/assets/72348855/2eacdf83-9ab4-47f5-8d89-f37c296808c9)

## License

This project is licensed under the [BDS 3 License](LICENSE).
