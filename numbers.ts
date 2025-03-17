import { readFileSync } from "fs";

const smallTest = './LargeTestList.txt';
const list = readFileSync(smallTest, 'utf-8');

const numbers = list.split('\n').map(Number);

const sum = numbers.reduce((acc, num) => acc + num, 0);
const average = sum / numbers.length;
const max = Math.max(...numbers);
const min = Math.min(...numbers);

console.log(`Sum: ${sum}`);
console.log(`Average: ${average}`);
console.log(`Max: ${max}`);
console.log(`Min: ${min}`);