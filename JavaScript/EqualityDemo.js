function compareValues(a, b) {
    console.log("Testing: " + a);
    return {
        looseEquality: a == b,
        strictEquality: a === b
    }
}

console.log(compareValues(1, 1));
console.log(compareValues(1, "1"));
console.log(compareValues(true, "1"));
console.log(compareValues(null, null));
console.log(compareValues(undefined, undefined));
console.log(compareValues(NaN, NaN));