def factorial(n):
    """Compute the factorial of a non-negative integer n."""
    if n == 0:
        return 1
    result = 1
    for i in range(1, n + 1):
        result *= i
    return result


def sum_of_digits(number):
    """Compute the sum of digits of a given integer number."""
    # Take the absolute value of the number to handle negative numbers
    number = abs(number)
    sum_digits = 0
    while number > 0:
        sum_digits += number % 10
        number //= 10
    return sum_digits

# # Example usage of factorial function
# print(factorial(5))  # Output: 120

# # Example usage of sum_of_digits function
# print(sum_of_digits(12345))  # Output: 15
