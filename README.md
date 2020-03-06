# _[Word Counter](https://github.com/TSiu88/WordCounter-Csharp)_

#### _Week 9 Independent Friday Assignment for [Epicodus](https://www.epicodus.com/), 03.06.2020_

#### By _**Tiffany Siu**_

## Description

_README under construction_
<!-- _Detailed desc w/ purpose/usage, what does, motivation to create, why exists, other info for users/developers to have_ -->

## Setup/Installation Requirements

### Requirements to Run
* _.NET Core_
* _Command Line Interface_

<!-- #### Javascript
* _Web Browser_
* _Webpack_
* _Node.js_
* _NPM_
* _API KEY_ -->

### Instructions

*This page may be viewed by:*

1. Download and install .NET Core from the [official website](https://dotnet.microsoft.com/download/dotnet-core/)
2. Clone the [repository](https://github.com/TSiu88/WordCounter-Csharp.git) from my [GitHub page](https://github.com/TSiu88)
3. Use a command line interface to move to the repository's directory with `cd project-directory`
4. Run `dotnet run` to start up the program in the command line interface 

## Other Technologies Used
* _C#_
* _MSTest_
* _Markdown_

<!-- #### Javascript
* _HTML_
* _CSS_
* _Javascript_
* _JQuery 3.4.1_
* _Bootstrap 4.4.1_
* _ESLint_
* _Babel_
* _Jest_
* _Markdown_ -->

## Notable Features
<!-- _features that make project stand out_ -->

## Specifications

<!-- * _The program returns an error message if the input word or sentence is empty or only white spaces._
  * _Example Input: word="", sentence=""_
  * _Example Output: output="Missing input word or sentence. Please enter valid items into input to continue."_
* _The program returns an error message if the input word for searching contains multiple words._
  * _Example Input: word="hi hello"_
  * _Example Output: output="Search word can only contain one word. Please try again."_
* _The program converts all inputs to be in lowercase for comparisons to find matches so searching for matches is case insensitive._
  * _Example Input: "HeLlO"_
  * _Example Output: "hello"_
* _The program does not count extra whitespaces as part of the word it is searching for._
  * _Example Input: input word="    white  "_
  * _Example Output: word for search="white"_
* _The program includes all numbers and special characters as part of the word it is searching for if given for input._
  * _Example Input: input word="h3llo!"_
  * _Example Output: word for search="h3llo!"_
* _The program returns a count of zero if no full word matches found (separated with spaces from other characters in the sentence, including punctuation and special characters)._
  * _Example Input: word="you", sentence="your you're joyous you!"_
  * _Example Output: count=0_
* _The program searches for full word matches only (separated by spaces from other characters in the sentence, including punctuation and special characters) and returns a count of the number of times it was found._
  * _Example Input: word="hello" sentence="Hello! Hello and hello again. Hello."_
  * _Example Output: count=2_
 -->

<details>
  <summary>Click to expand to view specifications</summary>

| Specification | Input | Output | Reason for Input Choice |
| :-------------     | :------------- | :------------- | :------------ |
| The program returns an error message if the input word or sentence is empty or only contains white spaces. | word="", sentence="" | output="Missing input word or sentence. Please enter valid items into input to continue." | Input is empty |
| The program does not count extra whitespaces as part of the word it is searching for. | input word="      white     " | word for search="white" | Input has extra whitespaces |
| The program returns an error message if the input word for searching contains multiple words. | word="hi hello" | output="Search word can only contain one word. Please try again." | Multiple word input not allowed for search |
| The program converts all inputs to be in lowercase for comparisons to find matches so searching for matches is case insensitive. | input word="HeLlO" | word for search="hello" | Input contains upper and lower case letters |
| The program includes all numbers and special characters as part of the word it is searching for if given for input. | input word="h3llo!" | word for search="h3llo!" | Input contains number and punctuation characters |
|The program returns a count of zero if no full word matches found (separated with spaces from other characters in the sentence, including punctuation and special characters). | word="you", sentence="your you're joyous you!" | count=0 | Input has different examples of non full word matches |
|The program searches for full word matches only (separated by spaces from other characters in the sentence, including punctuation and special characters) and returns a count of the number of times it was found. | word="hello" sentence="Hello! Hello and hello again. Hello." | count=2 | Input has a mixture of full word matches and non matches |

</details>

## User Stories

<!-- * As a scheduler, I want to be able to organize nurses vacation schedules without much paperwork so that I can be more efficient.
* As a scheduler, I want to see a list of requests with the overlapping dates and the nurses that sent in the requests organized by priority so I can see which staff member should have priority in getting the request approved. -->

<!-- * Give stories for people who will use this project and what they'd want it to do.  Can include customers/end users, programmers that maintain code, etc. -->


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

## Support and contact details

_If there are any question or concerns please contact me at my [email](mailto:tsiu88@gmail.com). Thank you._

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Tiffany Siu_**
