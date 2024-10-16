import unittest

def calc_words_in_file(filename):
    word_count = 0
    f = open(filename, "r")
    for line in f:
        words = line.split(" ")
        word_count += len(words)
    f.close()

    return word_count

# print(calc_words_in_file("Test File.txt"))

class TestWordCount(unittest.TestCase):

    def test_word_count(self):
        self.assertEqual(23, calc_words_in_file("Test File.txt"))

if __name__ == '__main__':
    unittest.main()
