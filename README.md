# WINDOWSDESKTOPAPP_Frontend
Frontend:

This C# code defines a Windows Forms application named GoogleFormsReplicaApp with a main form (Form1) that mimics a Google Forms submission process. The form includes text boxes for the user to input their name, email, phone number, GitHub link, and stopwatch time. When the user clicks the submit button, the application gathers the data from the text boxes, creates a Submission object with this data, serializes it to JSON format using Newtonsoft.Json, and sends it to a specified URL (http://localhost:3000/submit) using an HTTP POST request. The application uses HttpClient to handle the HTTP communication. If the submission is successful, a message box displays "Submission successful!"; otherwise, it shows "Submission failed.". The Submission class defines the structure of the data to be submitted, with properties for name, email, phone number, GitHub link, and stopwatch time.

STEPS:

Install Visual Studio: Download and install Visual Studio from the official Microsoft website. You can choose the Community edition, which is free for individuals and small teams.

Create a New Project: Open Visual Studio and create a new Windows Forms App (.NET Framework) project. You can name it GoogleFormsReplicaApp or any other name you prefer.

Copy and Paste Code: Replace the default code in Form1.cs with the code you provided.

Run the Application: Press F5 or click on the "Start" button in Visual Studio to run the application. This will compile the code and launch the Windows Forms application.

Test the Application: Enter some data into the text boxes and click the submit button to see if the submission is successful.

Optional: Modify the Backend URL: If you have a backend server running at a different URL than http://localhost:3000/submit, you can update the URL in the button1_Click method to match your backend server's URL.

Debugging: If you encounter any issues, you can use Visual Studio's debugging features to troubleshoot and fix them.





