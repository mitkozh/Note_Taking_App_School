# Note Taking App

## Introduction

Welcome to the Note Taking App README! This document provides an overview of the functionalities, technologies used, and instructions for setting up and using the Note Taking App.

## Table of Contents

1. [Introduction](#introduction)
2. [Technologies Used](#technologies-used)
3. [Features](#features)
4. [Setup Instructions](#setup-instructions)
5. [Usage](#usage)
6. [Contributing](#contributing)
7. [License](#license)

## Technologies Used

The Note Taking App is built using the following technologies:

- **C#:** Programming language used for developing the WinForms application.
- **WinForms (Windows Forms):** Framework utilized for creating the desktop application user interface.
- **Visual Studio:** Integrated Development Environment (IDE) employed for building and managing the project.
- **SQL Server Management Studio (SSMS):** Tool utilized for creating and managing the SQL Server database.
- **SQL Server Database:** Backend database employed for storing and retrieving notes.
- **ADO.NET:** Data access technology utilized for connecting the WinForms application to the SQL Server database.

## Features

The Note Taking App offers the following key features:

1. **Create, Save, and Delete Notes:** Users can create new notes, save them to the database, and delete existing notes.
2. **Date and Time Stamp:** Each note automatically includes a date and time stamp to track when the note was created.
3. **Error Handling:** The application implements proper error handling to ensure smooth user experience, with user-friendly error messages provided in case of any issues.
4. **Search Functionality:** Users can search for specific notes using keywords or phrases, enabling efficient retrieval of information.

## Setup Instructions

To set up the Note Taking App, follow these steps:

1. **Clone the Repository:** Clone the Note Taking App repository from GitHub to your local machine.
2. **Open in Visual Studio:** Open the project in Visual Studio IDE.
3. **Database Setup:** Use SQL Server Management Studio to set up the required database for the application. Execute the SQL script provided in the `Notes.sql` to create the necessary tables and schema. (**Note:** Run the SQL script before starting the application.)
4. **Database Connection:** Update the connection string in the application code to connect to your SQL Server database.
5. **Build and Run:** Build the solution in Visual Studio and run the application to start using the Note Taking App.

## Usage

Once the Note Taking App is set up, follow these steps to use it:

1. **Launch the Application:** Open the Note Taking App from your desktop or application menu.
2. **Create a New Note:** Click on the "New" button to create a new note.
3. **Write and Save:** Write your note in the provided text areas and click on the "Save" button to save it to the database.
4. **Delete Note:** To delete a note, select the note from the list and click on the "Delete" button.
5. **Search Notes:** Use the search bar to search for specific notes by entering keywords.
6. **View Date and Time Stamp:** Each note displays a date and time stamp indicating when it was last edited.

## Contributing

Contributions to the Note Taking App are welcome! If you'd like to contribute, please follow these guidelines:

1. Fork the repository and create a new branch for your feature or enhancement.
2. Make your changes and ensure they adhere to the coding standards and best practices.
3. Test your changes thoroughly to ensure they work as expected.
4. Submit a pull request with a clear description of your changes and the problem they solve.

## License

The Note Taking App is licensed under the [MIT License](LICENSE). You are free to use, modify, and distribute the application as per the terms of the license.

---

Thank you for using the Note Taking App! If you have any questions or encounter any issues, please don't hesitate to reach out to us. Happy note-taking!
