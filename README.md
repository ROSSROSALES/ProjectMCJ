# ProjectMCJ
GUI for entering the ID of the load and showing the target of the load for AGV

## Setup
1. Clone Repo
2. Open in Visual Studio
3. Build and Run

or

1. Clone Repo Locally
2. Navigate to ProjectMCJ\bin\MCJ Project - Ross\
3. Run ProjectMCJ.exe

## Using App
1. Choose folder that contains the text files with the information about delivery station loads
2. Input LoadID into textbox
3. Press LoadID button to retrieve Target location

### Features and Considerations
- The application will choose the most recent modified text file
- The application will still run if the current text file is removed (saves the most recent copy in memory)
- If a new text file is added into the folder, the application will read the newest file

