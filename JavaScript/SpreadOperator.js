const fruits = ["apple", "banana", "cherry"];
const vegetables = ["spinach", "carrot", "potato"];

// classical way to combine arrays
/*
const food = [];
for (let i = 0; i < fruits.length; i++) {
    food.push(fruits[i]);    
}
for (let i = 0; i < vegetables.length; i++) {
    food.push(vegetables[i]);    
}
*/

const food = [...fruits, ...vegetables];
console.log(food);