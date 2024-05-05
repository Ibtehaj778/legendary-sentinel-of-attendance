# Legendary Sentinel of Attendance

**Legendary Sentinel of Attendance** is a C# application built using EmguCV and WinForms, designed to efficiently manage student attendance through camera-based marking. This application offers a range of features to streamline attendance tracking and visualization for educational institutions.

## Features

- **Registering New Student**: Easily add new students to the system with relevant details.
- **Marking Present through Camera**: Utilize camera input to mark students present, ensuring accurate attendance records.
- **Feedback**: Collect feedback from users to continuously improve the application.
- **Adding Teacher**: Allow administrators to add teachers to the system for seamless management.
- **Display Attendance**: View detailed attendance records for individual students or classes.
- **Attendance Visualizations**: Visualize attendance data through charts and graphs for better insights.

## Implementation
<a href="https://ibb.co/pyCCrSx"><img src="https://i.ibb.co/3zttYn7/Add-Teacher.png" alt="Add-Teacher" border="0"></a>
<a href="https://ibb.co/QjG2f6B"><img src="https://i.ibb.co/84VW0j3/Attendance.png" alt="Attendance" border="0"></a>
<a href="https://ibb.co/VCjKdmG"><img src="https://i.ibb.co/s1mBhH4/Dashboard.png" alt="Dashboard" border="0"></a>
<a href="https://ibb.co/3mPm0Bk"><img src="https://i.ibb.co/1G4G98b/Feedback.png" alt="Feedback" border="0"></a>
<a href="https://ibb.co/0fc2hVH"><img src="https://i.ibb.co/64mwgJj/Graph.png" alt="Graph" border="0"></a>
<a href="https://ibb.co/7p5ZRt9"><img src="https://i.ibb.co/n1vYnMW/Login.png" alt="Login" border="0"></a>
<a href="https://ibb.co/KmH6YVD"><img src="https://i.ibb.co/4JxWc42/Register-New.png" alt="Register-New" border="0"></a>
<a href="https://ibb.co/JxwTSvg"><img src="https://i.ibb.co/yhcCx67/Show-Attendance.png" alt="Show-Attendance" border="0"></a>

## Model Metrics
<a href="https://ibb.co/tHyrLLP"><img src="https://i.ibb.co/vc2nXXv/model-metrics.png" alt="model-metrics" border="0"></a>

## System Architecture
<a href="https://ibb.co/PFpm4P1"><img src="https://i.ibb.co/DzXVkvw/Architecture.png" alt="Architecture" border="0"></a>

## Installation

1. Clone the repository to your local machine:

```bash
git clone https://github.com/ahmedembeddedx/legendary-sentinel-of-attendance.git
```

2. Open the solution file `LegendarySentinelOfAttendance.sln` in Visual Studio.

3. Install the following NuGet packages if not already installed:
   - `EMGU.CV.RUNTIME.WINDOWS`
   - `EMGU.CV`

   You can install these packages via the NuGet Package Manager in Visual Studio or by running the following commands in the Package Manager Console:

   ```bash
   dotnet add package emgu.cv.runtime.windows
   dotnet add package emgu.cv
   ```
   
4. Build and run the application.

## Usage
1. Locate /Project/ATTENDANCE++/WindowsFormsApp1/bin/Debug/Attendance.exe and double click
2. Launch the application after successful installation.
3. Navigate through the intuitive user interface to access different features.
4. Follow on-screen instructions to register new students, mark attendance, add teachers, and view attendance records.
5. Explore the visualization options to gain insights into attendance patterns.

## Contributing

Contributions are welcome! If you'd like to contribute to **Legendary Sentinel of Attendance**, please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/awesome-feature`).
3. Make your changes.
4. Commit your changes (`git commit -am 'Add some awesome feature'`).
5. Push to the branch (`git push origin feature/awesome-feature`).
6. Create a new Pull Request.

## License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT) - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Thanks to the EmguCV community for providing the tools necessary to work with computer vision in C#.
- Special thanks to Ibtehaj Ali for their valuable contributions to this project.
