import math
import unittest

def calc_sum(a, b):
    return a + b

def calc_product(a, b):
    return a * b

def calc_lcm(a, b):
    return abs(a * b) // math.gcd(a, b)
    # return math.lcm(a, b)


class TestCalculations(unittest.TestCase):

    def test_sum(self):
        self.assertEqual(3, calc_sum(1, 2))
        self.assertEqual(30, calc_sum(10, 20))
        self.assertEqual(-3, calc_sum(-1, -2))
        self.assertEqual(0, calc_sum(0, 0))

    def test_product(self):
        self.assertEqual(20, calc_product(4, 5))
        self.assertEqual(200, calc_product(10, 20))
        self.assertEqual(-50, calc_product(-10, 5))
        self.assertEqual(0, calc_product(0, 0))

    def test_lcm(self):
        self.assertEqual(10, calc_lcm(2, 5))
        self.assertEqual(6, calc_lcm(3, 6))
        self.assertEqual(77, calc_lcm(7, 11))
        self.assertEqual(0, calc_lcm(0, 8))


if __name__ == '__main__':
    unittest.main()
