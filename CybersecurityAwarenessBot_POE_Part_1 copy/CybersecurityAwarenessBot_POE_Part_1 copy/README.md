#Cybersecurity Assistant Console Application

## Overview
The **Cybersecurity Assistant** known as CycberWise is a simple, interactive console application built in C# that provides its users with helpful information about cybersecurity topics. It features a friendly command-line interface with ASCII art, color-coded text, and a typewriter effect for displaying answers. Users can ask predefined questions related to cybersecurity and receive informative responses.

---

## Features
- **Interactive Q&A:** Ask common cybersecurity questions and get instant answers.
- **User-friendly UI:** Colored text and ASCII art create an engaging console experience.
- **Typewriter Effect:** Answers are displayed with a typing animation for better readability.
- **Input Validation:** Prompts user to enter a valid name before proceeding.
- **Expandable Questions:** Supports showing more questions on demand.
- **Exit Command:** Users can type `exit` to quit the application gracefully.

---

## Usage

1. **Run the application**  
   Launch the program from your console or IDE.

2. **Enter your name**  
   The assistant will prompt you to enter your name. This cannot be empty.

3. **View available questions**  
   The program displays a list of example questions you can ask.

4. **Ask a question**  
   Type any of the listed questions or type `Show more questions I can ask about` to see additional topics.

5. **Exit**  
   Type `exit` at any prompt to close the application.

---

## Example Questions You Can Ask
- How are you?
- What’s your purpose?
- What can I ask you about?
- How can I create a strong password?
- What is phishing?
- How can I browse safely online?

---

## Code Structure

- **Program.cs**  
  Contains the main program logic including:
  - ASCII art display
  - User input handling
  - Question processing with `ProcessUserQuery`
  - Helper methods for UI and effects

- **Arrays class (in `trials` namespace)**  
  Holds the arrays of questions and answers, and a method to display all available questions.

---

## Dependencies
- Uses standard .NET libraries:
  - `System`
  - `System.Media` (for optional audio playback)
  - `System.Threading` (for delays and effects)
- Custom namespace `trials` for the `Arrays` class (make sure this is included in your project).

---

## License
This project is open source and free to use for educational purposes.

---

## Contact
For questions or suggestions, please open an issue or contact the author.

---

Thank you for using the Cybersecurity Assistant! Stay safe online. 🚀🔐

