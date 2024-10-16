// step 1: classical function
function calculateSum(a, b) {
    return a + b;
}

// step 2: anonymous function expression
let sumFunc = function(a, b) {
    return a + b;
}
console.log(sumFunc(1, 2)); // 3


// step 3: arrow function expression
let sumFunc2 = (a, b) => {
    return a + b;
}

// step 4: simplified arrow function expression
let sumFunc3 = (a, b) => a + b;
