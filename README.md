# _Scrabble Score Checker_

#### _C# Testing practice for Epicodus_, _Mar. 5, 2020_

#### By _**Michelle Morin**_

## Description

_This console application takes input of a word and returns the scrabble score for that word. Scrabble scoring uses the following points system:_
* _A, E, I, O, U, L, N, R, S, T       1_
* _D, G                               2_
* _B, C, M, P                         3_
* _F, H, V, W, Y                      4_
* _K                                  5_
* _J, X                               8_
* _Q, Z                               10_

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| Application creates instance of a word | "hello" | Word myWord = new Word("hello"); |
| Application loops through each letter of the word and returns a scrabble score for the word | "a" | 1 |
| Each "a", "e", "i", "o", "u", "l", "n", "r", "s", or "t" in the word increment the scrabble score by 1 point | "at" | 2 |
| Each "d" or "g" in the word increment the scrabble score by 2 points | "dog" | 5 |
| Each "b", "c", "m", or "p" increment the scrabble score by 3 points | "map" | 7 |
| Each "f", "h", "v", "w", or "y" incremenet the scrabble score by 4 points | "yawn" | 10 |
| Each "k" incremenets the scrabble score by 5 points | "yuck" | 13 |
| Each "j" or "x" incremenet the scrabble score by 8 points | "job" | 12 |
| Each "q" or "z" incremenet the scrabble score by 10 points | "zoo" | 12 |


## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone`` followed by the URL to this repository.
* ``cd`` followed by the repository name.

_Confirm that you have navigated to the correct directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this console application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``dotnet run``

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _dotnet script_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Michelle Morin_**