import unittest

def is_leap_year(year):
    if year % 400 == 0:
        return True
    if year % 4 == 0:
        if year % 100 == 0:
            return False
        else:
            return True
    else:
        return False

# print(is_leap_year(2024))
# print(is_leap_year(2023))

class TestLeapYear(unittest.TestCase):

    def test_is_leap_year(self):
        self.assertEqual(False, is_leap_year(2023))
        self.assertEqual(True, is_leap_year(2024))
        self.assertEqual(False, is_leap_year(2025))
        # ...

if __name__ == '__main__':
    unittest.main()