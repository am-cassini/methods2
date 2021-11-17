Methods
> Subject: ITN114 Wireless Internet and Pervasive Computing

> Language: C#

> IDE: Visual Studio 2019 

--- Instructions ---

Problem: String Encryption
Write a method Encrypt(char letter), which encrypts a given letter in the following way:

It takes the first and the last digit from the ASCII code of the letter and concatenates them into a string, which will represent the result.
In the beginning of the string, which represents the result, we will insert the symbol which matches the following condition:
ASCII code of the letter + the last digit of the ASCII code of the letter.
After that in the end of the string, which represents the result, you concatenate the character which matches the following condition:
ASCII code of the letter - the first digit of the ASCII code of the letter.
The method should return the encrypted string.
Example:

j → p16i
ASCII code of j is 106 → First digit – 1, last digit – 6.
We concatenate the first and the last digit → 16.
At the beginning of the string, which represents the result, concatenate the symbol, which you get from the sum of the ASCII code + the last digit → 106 + 6 → 112 → p.
At the end of the string, which represents the result, concatenate the symbol, which you get from subtracting the ASCII code – the first digit → 106 - 1 → 105 → i.
Using the method shown above, write a program which takes a sequence of characters, encrypts them and prints the result on one line.

The input data will always be valid. The Main method must read the data given by the user – an integer n, followed by a character for each of the following n lines.

Encrypt the symbols and add them to the encrypted string. In the end, as a result, you must print an encrypted string as in the following example.

Example:

S, o, f, t, U, n, i → V83Kp11nh12ez16sZ85Mn10mn15h
