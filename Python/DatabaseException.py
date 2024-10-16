import unittest

def connect_to_database(db_url):
    if not db_url.startswith("db://"):
        raise ValueError("Invalid database URL")

    # Simulate a database connection here
    return "Connected"

class TestDatabaseAccess(unittest.TestCase):

    def test_happy_path(self):
        self.assertEqual("Connected", connect_to_database("db://server.local/"))

    def test_exception_1(self):
        try:
           connect_to_database("my-server-name")
           self.assertTrue(False)
        except ValueError:
            self.assertTrue(True)
            return
        self.assertTrue(False)

    def test_exception_2(self):
        with self.assertRaises(ValueError):
            connect_to_database("my-server-name")
     

if __name__ == '__main__':
    unittest.main()