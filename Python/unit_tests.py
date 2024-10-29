import unittest
from calc import *

class TestLaskutoimitukset(unittest.TestCase):
    def test_summa(self):
        self.assertEqual(summa(3, 2), 5)
        self.assertEqual(summa(-1, 1), 0)
        self.assertEqual(summa(0, 0), 0)

    def test_erotus(self):
        self.assertEqual(erotus(3, 2), 1)
        self.assertEqual(erotus(-1, 1), -2)
        self.assertEqual(erotus(0, 0), 0)

    def test_tulo(self):
        self.assertEqual(tulo(3, 2), 6)
        self.assertEqual(tulo(-1, 1), -1)
        self.assertEqual(tulo(0, 5), 0)

    def test_jakolasku(self):
        self.assertEqual(jakolasku(6, 2), 3)
        self.assertEqual(jakolasku(-4, 2), -2)
        with self.assertRaises(ValueError):
            jakolasku(5, 0)

if __name__ == '__main__':
    unittest.main()