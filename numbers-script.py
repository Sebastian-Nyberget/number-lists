import time
import tracemalloc

start_time = time.time()
tracemalloc.start()

with open('LargeTestList.txt', 'r') as file:
    numbers = [int(line) for line in file]

print(f"Sum: {sum(numbers)}")
print(f"Gjennomsnitt: {sum(numbers) / len(numbers)}")
print(f"Største verdi: {max(numbers)}")
print(f"Minste verdi: {min(numbers)}")

current, peak = tracemalloc.get_traced_memory()
tracemalloc.stop()

end_time = time.time()
print(f"Response time: {(end_time - start_time) * 1000:.2f} ms")
print(f"Current Memory Usage: {current / (1024 * 1024):.2f} MB")
print(f"Peak Memory Usage: {peak / (1024 * 1024):.2f} MB")