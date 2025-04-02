# InfernoNotificationManager

## Overview

InfernoNotificationManager is a custom notification system designed to intercept and display notifications from any application on Windows. The notifications are displayed with a blue over bar and bold application name, ensuring they stand out.

## Features

- **Intercept Notifications**: Automatically intercept notifications from any application.
- **Custom Notifications**: Display custom notifications with a blue over bar and bold application name.
- **Notification Sound**: Play a custom sound when a notification is displayed.
- **Windows Service**: Runs as a Windows Service to continuously intercept and display notifications.

## Installation

### Prerequisites

- .NET Framework 4.7.2 or later
- Administrator privileges to install and manage Windows Services

### Steps

1. **Clone the Repository**:
   ```sh
   git clone https://github.com/infernogpt/InfernoNotificationManager.git
   cd InfernoNotificationManager
   ```

2. **Build the Solution**:
   Open the solution in Visual Studio and build it. Ensure there are no compilation errors.

3. **Install the Windows Service**:
   Use `InstallUtil.exe` to install the `NotificationInterceptorService` as a Windows Service.
   ```sh
   InstallUtil.exe path\to\NotificationInterceptorService.exe
   ```

4. **Start the Windows Service**:
   Open the Services management console (`services.msc`), find `NotificationInterceptorService` in the list, and start the service.

## Usage

Once the service is running, it will automatically intercept notifications from any application and display them using the custom notification system.

## Contributing

We welcome contributions! Please follow these steps to contribute:

1. Fork the repository.
2. Create a new branch with a descriptive name.
3. Make your changes and commit them with descriptive messages.
4. Push your changes to your fork.
5. Create a pull request to the main repository.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

Skidding from this project is strictly prohibited. If I find out you skid, legal action will be taken. 

## Contact

For any questions or suggestions, please open an issue or contact us at support@infernogpt.com.
