# Palindrome Checker (C#)

A web app, built with C#, that allows users to enter a string and check whether said string is a palindrome (that is, whether it is identical when read forward and when read backwards).

## Installation

1. Install .NET, if not already present on your local machine.

2. Clone this repository.

3. In your preferred shell, navigate to the Palindromes folder and run the following commands:

 ```
 $ dotnet restore
 ```
(above not required for .NET Core 2.0 SDK or newer releases)

 ```
 $ dotnet run
 ```

4. Navigate to localhost:5000 in your preferred browser.

## Specifications

1. App routes users to the home page, where users may submit a string to be examined.

2. When a string is submitted, the string is displayed below the form along with a message confirming whether or not the string is a palindrome. Capitalization and whitespace are ignored when determining this.
    1. Example Input: "Aha"
    2. Example Output: "Congrats, your input is a palindrome!".

    3. Example Input: "race car"
    4. Example Output: "Congrats, your input is a palindrome!"

    5. Example Input: "hello"
    6. Example Output: "Not a palindrome, sorry!"


### Built With

* [Atom](https://atom.io/) - Open-source, hackable code editor running on the Electron framework.

### Support and Contact Details
If you encounter any bugs or would like to make suggestions regarding this project, please feel free to open an issue within the repository.

### License

This project is distributed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
