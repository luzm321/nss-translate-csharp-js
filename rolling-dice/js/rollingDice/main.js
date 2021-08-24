// Put your code here

console.log("Let's roll some dice, baby!");
console.log("---------------------------");


const convertDieIntToString = (dieValue) => {
    let dieString = "";

    switch (dieValue) {
        case 1: 
            dieString = "one";
            break;
        case 2:
            dieString = "two";
            break;
        case 3: 
            dieString = "three";
            break;
        case 4: 
            dieString = "four";
            break;
        case 5:
            dieString = "five";
            break;
        case 6:
            dieString = "six";
            break;
    }

    return dieString;
};

const makeDieObj = (result) => {
    const dieObj = {
        dieValue: result,
        resultValue: convertDieIntToString(result)
    }

    return dieObj;
}

// Function to "roll" a die:
// Generates a random number between 1 and 6:
// const Roll = (min, max) => {
//     min = Math.ceil(min);
//     max = Math.floor(max);
//     return Math.floor(Math.random() * (max - min + 1)) + min;
// };
const Roll = () => {
    const result = Math.floor(Math.random() * 6) + 1;
    const dieObject = makeDieObj(result);
    return dieObject;
};

for (let i = 0; i < 10; i++) {
    let die1 = Roll();
    let die2 = Roll();

    let message = `${die1.resultValue} + ${die2.resultValue} == ${die1.dieValue + die2.dieValue}`;
    if (die1.dieValue === die2.dieValue) {
        message += " DOUBLES!";
    } else {
        console.log(message);
    }
};