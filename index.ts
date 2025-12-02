import promptSync from 'prompt-sync'
const prompt = promptSync();




let n: number;
let output: string = "";

n = parseInt(prompt("Enter a number: "));



for (let i = 1; i <= n; i++) {
    if (i % 3 == 0 && i % 5 == 0){
        output += "FizzBuzz ";
    } else if (i % 3 == 0){
        output += "Fizz ";
    } else if (i % 5 == 0){
        output += "Buzz ";
    } else {
        output += i + " ";
    }
}
console.log(output);



// Bonus part:

function isPrime (x : number) : boolean {
    if (x <= 1) return false;
    if (x == 2) return true;
    if (x % 2 == 0) return false;

    for (let i = 3; i <= Math.sqrt(x); i += 2) {
        if (x % i == 0) {
            return false
        }
    }
    return true;
}



console.log("Bonus part: ")


let valid: boolean = false;
let number: number;
let out: string = "";
let k: number = 1;

do {
    k++;
    number = parseInt(prompt("Enter a number between 10 and 200: "));
    if (!isNaN(number) && number <= 200 && number >= 10){
        valid = true;
        break;
    }
} while (k <= 3);



let CountPrimes: number = 0;
let SumEven: number = 0;
let MaxOdd: number = 0;
let SumDivBy7: number = 0;


if (valid) {
    for (let i = 1; i <= number; i++) {
    if (i % 3 == 0 && i % 5 == 0){
        out += "FizzBuzz ";
    } else if (i % 3 == 0){
        out += "Fizz ";
    } else if (i % 5 == 0){
        out += "Buzz ";
    } else if (isPrime(i)) {
        out += `[${i}]`;
        CountPrimes++;
    } else {
        out += i + " ";
    }

    if (i % 2 == 0){
        SumEven += i;
    }
    if (i % 2 == 1){
        MaxOdd = i;
    }
    if (i % 7 == 0){
        SumDivBy7 += i;
    }
}
console.log(out);

} else {
    console.log("Too many invalid attempts. Exiting");
}


console.log(`CountPrimes: ${CountPrimes}`);
console.log(`SumEven: ${SumEven}`);
console.log(`MaxOdd: ${MaxOdd}`);
console.log(`SumDivBy7: ${SumDivBy7}`);
console.log("Well done, Keti! You combined loops and conditionals successfully.")