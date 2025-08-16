[한국어 버전 보기](README.ko.md)

# Tizen Galaxy Watch Xamarin.Forms Samples

This project is a comprehensive collection of sample implementations for various UI components and features, designed to assist developers in building Tizen Galaxy Watch applications using Xamarin.Forms (C#.NET). It serves as a practical guide and reference for understanding and utilizing different aspects of Xamarin.Forms on the Tizen wearable platform.

## Features

This repository includes individual sample pages demonstrating the usage of various Xamarin.Forms controls and layouts tailored for Tizen Galaxy Watch. Each `.xaml` file (along with its `.xaml.cs` code-behind) represents a distinct sample.

Here's a list of the included samples:

*   `AbsoluteLayout1.xaml`: Demonstrates basic usage of AbsoluteLayout.
*   `AbsoluteLayoutEx.xaml`: Provides an extended example of AbsoluteLayout.
*   `ButtonEx.xaml`: Shows various button configurations and event handling.
*   `CheckBoxEx.xaml`: Examples of CheckBox usage.
*   `DatePicker.xaml`: Demonstrates the DatePicker control.
*   `EditorEx.xaml`: Examples of the Editor control for multi-line text input.
*   `EntryEx.xaml`: Shows various configurations for the Entry control (single-line text input).
*   `FirstPage.xaml`: A generic sample page, potentially for initial navigation or simple content.
*   `FlexEx.xaml`: Demonstrates the FlexLayout for flexible UI arrangements.
*   `FrameEx.xaml`: Examples of using the Frame control for grouping and styling.
*   `GridEx.xaml`: Comprehensive examples of Grid layout for structured UIs.
*   `ImageEx.xaml`: Shows how to display and manipulate images.
*   `MyContentPage1.xaml`: Another generic content page sample.
*   `MyContentView1.xaml`: Demonstrates creating and using a custom ContentView.
*   `PopupEx.xaml`: Examples of displaying pop-up elements.
*   `PromptEx.xaml`: Shows how to use prompt dialogs.
*   `RelativeEx.xaml`: Demonstrates the RelativeLayout for positioning elements relative to each other.
*   `ScrollViewHori.xaml`: Horizontal scrolling examples using ScrollView.
*   `ScrollViewVertical.xaml`: Vertical scrolling examples using ScrollView.
*   `SecondPage.xaml`: Another generic sample page.
*   `SliderEx.xaml`: Examples of the Slider control.
*   `SwtichEx.xaml`: Demonstrates the Switch control.
*   `TableViewEx.xaml`: Examples of using TableView for structured data display.
*   `ThirdPage.xaml`: Another generic sample page.
*   `TimePicker.xaml`: Demonstrates the TimePicker control.

## Prerequisites

To build and run this project, you will need:

*   **Visual Studio**: With the "Mobile development with .NET" workload installed.
*   **Tizen SDK**: Ensure you have the Tizen SDK installed, including the Tizen Wearable tools and emulator images.
*   **.NET Core SDK**: Required for building .NET applications.

## Setup Instructions

1.  **Clone the Repository**:
    ```bash
    git clone https://github.com/your-repo-link/TizenGalaxyWatchApp.git
    cd TizenGalaxyWatchApp
    ```
    (Note: Replace `https://github.com/your-repo-link/TizenGalaxyWatchApp.git` with the actual repository URL if available.)

2.  **Open in Visual Studio**:
    Open the `TizenWatchXamlApp1.sln` file in Visual Studio.

3.  **Set Startup Project**:
    In the Solution Explorer, right-click on the `TizenWatchXamlApp1` project and select "Set as Startup Project".

4.  **Build the Solution**:
    Build the entire solution to restore NuGet packages and compile the code.

5.  **View a Specific Sample**:
    To run and view a specific sample, you need to modify the `App.xaml.cs` file. Open `TizenWatchXamlApp1/App.xaml.cs` and change the `MainPage` assignment to the desired sample page.

    For example, to view the `ButtonEx` sample, change:
    ```csharp
    MainPage = new MainPage();
    ```
    to:
    ```csharp
    MainPage = new ButtonEx();
    ```
    Remember to add `using TizenWatchXamlApp1;` if not already present.

6.  **Deploy and Run**:
    Select a Tizen Galaxy Watch emulator or a connected device from the Visual Studio toolbar and run the application.

## Project Structure

*   `TizenWatchXamlApp1/`: The main project directory containing all source code.
    *   `.xaml` files: Define the user interface for each sample page.
    *   `.xaml.cs` files: The code-behind for the XAML pages, containing logic and event handlers.
    *   `App.xaml` and `App.xaml.cs`: The application's entry point and main application class.
    *   `MainPage.xaml` and `MainPage.xaml.cs`: A basic placeholder page.
    *   `tizen-manifest.xml`: The Tizen application manifest file, defining application properties and permissions.
    *   `TizenWatchXamlApp.csproj`: The project file, defining dependencies and build settings.
*   `TizenWatchXamlApp1/asset/img/`: Contains image assets used within the application (e.g., `Tizen-logo.png`).
*   `bin/` and `obj/`: Directories for compiled binaries and intermediate build files.
*   `.git/`: Git version control directory.
*   `.vs/`: Visual Studio solution files.

## License

This project is licensed under the [LICENSE](LICENSE) file. Please refer to the `LICENSE` file for more details.

## Contact

For any inquiries or feedback, please contact:

*   **Jaehong Park** - jaehong1972@gmail.com