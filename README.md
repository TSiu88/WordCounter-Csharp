# _[Word Counter](https://github.com/TSiu88/WordCounter-Csharp)_

![LastCommit](https://img.shields.io/github/last-commit/tsiu88/wordcounter-csharp)
![Languages](https://img.shields.io/github/languages/top/tsiu88/wordcounter-csharp)
[![MIT license](https://img.shields.io/badge/License-MIT-yellow.svg)](https://lbesson.mit-license.org/)

#### _Week 9 Independent Friday Assignment for [Epicodus](https://www.epicodus.com/), 03.06.2020_

#### By _**Tiffany Siu**_
---
## Table of Contents
1. [Description](#description)
2. [Setup/Installation Requirements](#setup/installation-requirements)
    - [Requirements to Run](#requirements-to-run)
    - [Instructions](#instructions)
    - [Other Technologies Used](#other-technologies-used)
3. [Notable Features](#notable-features)
4. [Specifications](#specifications)
5. [Screenshots](#screenshots)
6. [Test Case Example](#test-case-example)
7. [Known Bugs](#known-bugs)
8. [Support and Contact Details](#support-and-contact-details)
9. [License](#license)
---
## Description

_README under construction_
<!-- _Detailed desc w/ purpose/usage, what does, motivation to create, why exists, other info for users/developers to have_ -->

## Setup/Installation Requirements

### Requirements to Run
* _.NET Core_
* _Command Line Interface_

### Instructions

*This page may be viewed by:*

1. Download and install .NET Core from the [official website](https://dotnet.microsoft.com/download/dotnet-core/)
2. Clone the [repository](https://github.com/TSiu88/WordCounter-Csharp.git) from my [GitHub page](https://github.com/TSiu88)
3. Use a command line interface to move to the repository's directory with `cd project-directory`
4. Run `dotnet restore wordcounter` and `dotnet restore wordcounter.tests` to create obj and bin folders for program to run in the command line interface
5. Run `dotnet run` to start up the program in the command line interface 

### Other Technologies Used
* _C#_
* _MSTest_
* _Markdown_

## Notable Features
<!-- _features that make project stand out_ -->

## Specifications

<details>
  <summary>Click to expand to view specifications</summary>

| Specification | Input | Output | Reason for Input Choice |
| :-------------     | :------------- | :------------- | :------------ |
| The program converts all inputs to be in lowercase for comparisons to find matches so searching for matches is case insensitive. | input word="HeLlO" | word for search="hello" | Input contains upper and lower case letters |
| The program includes all numbers and special characters as part of the word it is searching for if given for input. | input word="h3llo!" | word for search="h3llo!" | Input contains number and punctuation characters |
| The program does not count extra whitespaces as part of the word it is searching for. | input word="      white     " | word for search="white" | Input has extra whitespaces |
| The program returns an error message if the input word or sentence is empty or only contains white spaces then asks again for input. | word="", sentence="" | output="Empty or multiple words to match not valid.  Please try again." OR output="Empty sentence to search not valid.  Please try again." | Input is empty |
| The program returns an error message if the input word for searching contains multiple words. | word="hi hello" | output="Empty or multiple words to match not valid.  Please try again." | Multiple word input not allowed for search |
|The program returns a count of zero if no full word matches found (separated with spaces from other characters in the sentence, including punctuation and special characters). | word="you", sentence="your you're joyous you!" | count=0 | Input has different examples of non full word matches |
|The program searches for full word matches only (separated by spaces from other characters in the sentence, including punctuation and special characters) and returns a count of the number of times it was found. | word="hello" sentence="Hello! Hello and hello again. Hello." | count=2 | Input has a mixture of full word matches and non matches |

</details>

## Screenshots

<!-- _Here is a snippet of what the input looks like:_

![Snippet of input fields](img/snippet1.png)

_Here is a preview of what the output looks like:_

![Snippet of output box](img/snippet2.png) -->

<!-- _{Show pictures using ![alt text](image.jpg), show what library does as concisely as possible but don't need to explain how project solves problem from `code`_ -->

## Test Case Example
<!-- _Tests are done through Jest and are run from the command line prompt with `npm test`._
_Some example tests:_
![Snippet of an example test](img/test1.png)

![Snippet of an example result](img/test2.png) -->
<!-- _describe and show how to run tests with `code` examples}_ -->

## Known Bugs

_There are currently no known bugs in this program_

## Support and Contact Details

_If there are any question or concerns please contact me at my [email](mailto:tsiu88@gmail.com). Thank you._

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Tiffany Siu_**
