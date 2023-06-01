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
1. Choose folder that contains the text files with the information about delivery station loads (try the SampleData folder in the root of this repo)
2. Input LoadID into textbox
3. Press LoadID button to retrieve Target location

### Features and Considerations
- The application will choose the most recent modified text file
- The application will still run if the current text file is removed (saves the most recent copy in memory)
- If a new text file is added into the folder, the application will read the newest file

## MVP Walkthrough  
1. Initial Interface

![image](https://github.com/ROSSROSALES/ProjectMCJ/assets/52366381/cc271616-2cd8-4753-a07a-3289c4f4248f)  

2. Selecting Folder with Data

![Screenshot 2023-05-31 190925](https://github.com/ROSSROSALES/ProjectMCJ/assets/52366381/f3a20747-dcde-44b0-b825-d49633df666d)  

3. Sample Data in the folder chosen

![image](https://github.com/ROSSROSALES/ProjectMCJ/assets/52366381/d568a58c-b1bd-4a22-b1ff-077ea2452a26)  

4. Inputting a LoadID and returning the Target

![image](https://github.com/ROSSROSALES/ProjectMCJ/assets/52366381/9cd02e13-7a3e-4be3-943d-0c173ec9b293)  

5. If the LoadID is incorrect or does not exist, "Does Not exist" informs the user

![image](https://github.com/ROSSROSALES/ProjectMCJ/assets/52366381/c1ef7938-671b-4576-a6fc-9cd0616d3c68)  

6. Here we test what happens when we update/modify a text file.  
  sample2.txt is a copy of sample.txt  
  In this screenshot, we update the sample2.txt with a new LoadID of "123456" (named for testing purposes)

![image](https://github.com/ROSSROSALES/ProjectMCJ/assets/52366381/2fccd592-8ea3-4028-b9c4-c55a8fa16ea7)

![image](https://github.com/ROSSROSALES/ProjectMCJ/assets/52366381/bc895be5-d518-4115-9e79-097c5ef91d3d)  

7. When we delete a file, we can still run the application and search previously saved data  

![image](https://github.com/ROSSROSALES/ProjectMCJ/assets/52366381/cd435b6c-34e1-4979-af5a-b16f234f2eca)

![image](https://github.com/ROSSROSALES/ProjectMCJ/assets/52366381/e97e88c3-9736-46da-a46b-c23a543911df)
