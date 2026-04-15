🧮 ASP.NET Core MVC Calculator

A lightweight, web-based calculator built with ASP.NET Core MVC. 
This project was developed as a challenge to implement full calculator functionality with a strict constraint: No client-side programming (JavaScript).
 
 
🎯 The Challenge

The goal was to build a functional calculator where:
All logic is executed on the server-side.
The UI is updated via the Request-Response cycle.
Application state is maintained across "stateless" HTTP requests using Hidden Form Fields.


🚀 Features

Basic Arithmetic: Addition, Subtraction, Multiplication, and Division.
State Management: Remembers the current calculation even though it's server-side.
Robust Logic: Handles decimal points, backspacing and division-by-zero errors.
Modern UI: Responsive design built with CSS Grid (no external CSS frameworks).
Clean Architecture: Implements the Model-View-Controller (MVC) pattern.


🛠️ Tech Stack

Backend: .NET 8.0 / C#
Frontend: HTML5, CSS3 (Grid/Flexbox)
Framework: ASP.NET Core MVC


🧠 How it Works
Since JavaScript is not used, every button click triggers a POST request to the HomeController.
The View sends the current state (hidden fields) and the clicked button (action) to the server.
The Controller processes the logic and updates the ViewModel.
The server sends back a fresh HTML page with the updated display.


🏁 Getting Started

Prerequisites
.NET 8.0 SDK
Visual Studio

Installation & Run

Clone the repository:

git clone [https://github.com/YOUR_USERNAME/YOUR_REPO_NAME.git](https://github.com/grekhviashviliofficial/CalculatorApp)


📝 Learning Outcomes

Understanding the HTTP Request-Response cycle.
Managing statelessness in web applications.
Deep dive into ASP.NET Core Model Binding and Tag Helpers.
Implementing clean code by separating logic into private methods.
