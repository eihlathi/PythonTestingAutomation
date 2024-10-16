// function fibonacci(n, memo = []) {
//     if (n <= 0) {
//         return 0;
//     } else if (n === 1) {
//         return 1;
//     }
//     if (!memo[n]) {
//         return fibonacci(n - 1, memo) + fibonacci(n - 2, memo);
//     }
//     return memo[n];
// }

function fibonacci(n, memo = []) {
    if (n <= 0) {
        return 0;
    } else if (n === 1) {
        return 1;
    }
    if (memo[n] !== undefined) {
        return memo[n];
    }
    memo[n] = fibonacci(n - 1, memo) + fibonacci(n - 2, memo);
    return memo[n];
}

console.log(fibonacci(50));
