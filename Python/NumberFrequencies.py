numbers = []

while True:
    print("Please enter a number between 1 and 99, or zero to exit:")
    number = int(input())
    if number == 0:
        break
    numbers.append(number)

# sorting and display
numbers.sort()
print(numbers)

# frequency calcutions
# frequencies = { "1-9": 0, "10-99": 0, ... }
frequencies = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0]

for n in numbers:
    bracket = n // 10
    frequencies[bracket] = frequencies[bracket] + 1

print(frequencies)

# if number <= 9:
#     frequencies["1-9"] = frequencies["1-9"] + 1
# elif number <= 19:
#     frequencies["10-19"] = frequencies["10-19"] + 1
