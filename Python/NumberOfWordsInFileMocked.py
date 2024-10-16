import unittest
from unittest.mock import mock_open, patch

def calc_words_in_file(filename):
    word_count = 0
    f = open(filename, "r")
    for line in f:
        print("Processing line: " + line)
        words = line.split(" ")
        word_count += len(words)
    f.close()

    return word_count

# print(calc_words_in_file("Test File.txt"))

class TestWordCount(unittest.TestCase):

    @patch("builtins.open", new_callable=mock_open, read_data="first second third")
    def test_word_count(self, mock_file):
        self.assertEqual(3, calc_words_in_file("dummy_file.txt"))

if __name__ == '__main__':
    unittest.main()
