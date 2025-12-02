 Lecture 3 – Exercise 1
Conditional Logic + loops in languages C#, Typescript, Python.

Objective:
Practice using if / else, for, and foreach (or equivalent) statements.
Strengthen logical thinking through condition checking and repetition.
Produce identical behavior across C#, TypeScript, and Python.

Task Overview:
In this exercise, you will build a more advanced console application using what you have learned so far: loops, if/else statements, and console input/output. You will write the same program in C#, TypeScript (Node.js), and Python. The goal is to use conditionals and loops in combination, validate user input, perform numeric analysis such as FizzBuzz and prime detection, calculate factorials, and print a detailed, consistent output across all three languages.
FizzBuzz is a famous beginner programming challenge that tests logic and control flow. You print numbers from 1 to N, but if the number is divisible by 3 you print Fizz, if it is divisible by 5 you print Buzz, and if it is divisible by both 3 and 5 you print FizzBuzz. Otherwise, you print the number itself.

Example for N = 15:
1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz
An out put should be one line, so concatenate the string.

Bonus:
If you finished FizzBuzz here is a complicated version for you.

Ask the user to enter a number N between 10 and 200.
Validate the input so that if the value is outside this range or not an integer, the program asks again.
After three invalid attempts, print
“Too many invalid attempts” instead. Exiting.” - and stop.
Generate all numbers from 1 to N and build a single output line where each number is separated by a space.


For each number apply the following logic in this exact order:
 If divisible by both 3 and 5 → print FizzBuzz
Else if divisible by 3 → print Fizz
Else if divisible by 5 → print Buzz
Else if the number is prime → print the number inside square brackets, for example [7]
Otherwise print the number itself
The result must still be one single line, not multiple lines.
After printing the sequence, calculate and display the following summary values:
CountPrimes = X
SumEven = Y
MaxOdd = Z
SumDivBy7 = W
where X is the total number of primes, Y the sum of even numbers, Z the largest, odd number, and W the sum of all numbers divisible by 7.
And finally print out closing message:

Well done, <Name>! You combined loops and conditionals successfully.



