with open('LargeTestList.txt', 'r') as file:
    numbers = [int(line) for line in file]

print(f"Sum: {sum(numbers)}")
print(f"Gjennomsnitt: {sum(numbers) / len(numbers)}")
print(f"Største verdi: {max(numbers)}")
print(f"Minste verdi: {min(numbers)}")