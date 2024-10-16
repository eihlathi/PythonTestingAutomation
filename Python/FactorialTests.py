import unittest

# Import the functions to be tested
from Factorial import factorial, sum_of_digits

class TestFactorialFunction(unittest.TestCase):

    def test_factorial(self):
        # Test cases
        self.assertEqual(factorial(0), 1)
        self.assertEqual(factorial(1), 1)
        self.assertEqual(factorial(3), 6)
        self.assertEqual(factorial(5), 120)
        self.assertEqual(factorial(10), 3628800)

    # Additional test for factorial function (optional)
    def test_factorial_large_number(self):
        # Test a large factorial
        self.assertEqual(factorial(20), 2432902008176640000)

class TestSumOfDigitsFunction(unittest.TestCase):

    def test_sum_of_digits(self):
        # Test cases
        self.assertEqual(sum_of_digits(0), 0)
        self.assertEqual(sum_of_digits(5), 5)
        self.assertEqual(sum_of_digits(12345), 15)
        self.assertEqual(sum_of_digits(987654321), 45)
        self.assertEqual(sum_of_digits(111111111), 9)

    # Additional test for sum_of_digits function (optional)
    def test_sum_of_digits_negative_number(self):
        # Test a negative number
        self.assertEqual(sum_of_digits(-12345), 15)

if __name__ == '__main__':
    unittest.main()
