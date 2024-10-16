// practice 15, section A

// function add(a, b) {
//     return a + b;
// }
let add = (a, b) => a + b;

const myObject = {
    value: 10,
    multiply: function (n) {
        setTimeout(() => {
            console.log(this.value * n);
        }, 5000);
    }
};

console.log("Calling the Multiply() method...");
myObject.multiply(5);

// wait for a keypress to exit
process.stdin.resume();
process.stdin.setEncoding("utf8");
process.stdin.setRawMode(true);

process.stdin.on("data", (key) => {
    console.log("Exiting application.");
    process.exit();
});

process.on("exit", () => {
    process.stdin.setRawMode(false);
    process.stdin.pause();
});
console.log("Press any key to exit...");
