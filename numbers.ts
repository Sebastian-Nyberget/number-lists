import { readFileSync } from "fs";

const filePath = './LargeTestList.txt';
const list = readFileSync(filePath, 'utf-8');
const start = Date.now();

const numbers = list.split('\n').map(Number);

const sum = numbers.reduce((acc, num) => acc + num, 0);
const average = sum / numbers.length;
const max = Math.max(...numbers);
const min = Math.min(...numbers);

console.log(`Sum: ${sum}`);
console.log(`Average: ${average}`);
console.log(`Max: ${max}`);
console.log(`Min: ${min}`);

const end = Date.now();
console.log(`Response Time: ${end - start}ms`);

const memoryUsage = process.memoryUsage();
console.log(`Memory Usage: ${memoryUsage.rss / 1024 / 1024}MB`);