import math



In = int(input("Enter a number: "))

for i in range(1, In + 1) :
    if i % 3 == 0 and i % 5 == 0:
        print("FizzBuzz ", end=" ")
    elif i % 3 == 0:
        print("Fizz ", end=" ")
    elif i % 5 == 0:
        print("Buzz ", end=" ")
    else:
        print(i, end=" ")





# Bonus part:

print("Bonus part: ")

CountPrimes = 0
SumEven = 0
MaxOdd = 0
SumDivBy7 = 0
k = 1
valid = False

def isPrime(number) :
    if number <= 1: return False
    if number == 2: return True
    if number % 2 == 0: return False
    for i in range(3, int(math.sqrt(number)) + 1, 2) :
        if number % i == 0: return False
    return True
    

ui = input("Enter a number between 10 and 200: ")

while k <= 2:
    if ui and ui.isdigit():
        if 200 >= int(ui) >= 10:
            valid = True
            break
    else :
        ui = input("Enter a number between 10 and 200: ")
    k += 1

if valid:
    num = int(ui)
    for i in range(1, num + 1) :
        if i % 3 == 0 and i % 5 == 0:
            print("FizzBuzz ", end=" ")
        elif i % 3 == 0:
            print("Fizz ", end=" ")
        elif i % 5 == 0:
            print("Buzz ", end=" ")
        elif isPrime(i):
            print(f"[{i}]", end=" ")
            CountPrimes += 1
        else:
            print(i, end=" ")

        if i % 2 == 0:
            SumEven += i 
        if i % 2 == 1:
            MaxOdd = i 
        if i % 7 == 0:
            SumDivBy7 += i

else : print("Too many invalid attempts. Exiting")


print(f"\nCountPrimes: {CountPrimes}")
print(f"SumEven: {SumEven}")
print(f"MaxOdd: {MaxOdd}")
print(f"SumDivBy7: {SumDivBy7}")
print("Well done, Keti! You combined loops and conditionals successfully.")

