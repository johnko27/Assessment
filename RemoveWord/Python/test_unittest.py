import removeWord    # The code to test
import unittest      # The test framework

class Test_RemoveWordFromString(unittest.TestCase):
    def test_punc_one(self):
        self.assertEqual(removeWord.remove_word_from_sentence("Papa is a good guy.", "guy"), "Papa is a good")

    def test_punc_two(self):
        self.assertEqual(removeWord.remove_word_from_sentence("Papa, is a good guy", "good"), "Papa is a guy")

    def test_one_word(self):
        self.assertEqual(removeWord.remove_word_from_sentence("Papa is a good guy", "good"), "Papa is a guy")

    def test_multiple_words(self):
        self.assertEqual(removeWord.remove_word_from_sentence("Papa good is a good guy", "good"), "Papa is a guy")

    def test_spaces(self):
        self.assertEqual(removeWord.remove_word_from_sentence("Papa is a  good guy", " "), "Papa is a good guy")

    def test_strip(self):
        self.assertEqual(removeWord.remove_word_from_sentence("Papa is a good guy ", "good"), "Papa is a guy")
    
    def test_trail(self):
        self.assertEqual(removeWord.remove_word_from_sentence("Papa is a good guy", "Papa"), "is a good guy")

    def test_in(self):
        self.assertEqual(removeWord.remove_word_from_sentence("Papagood is a good guy", "good"), "Papagood is a guy")

    def test_case(self):
        self.assertEqual(removeWord.remove_word_from_sentence("Papa is a goOd Good guy", "good"), "Papa is a guy")

    def test_sentence_empty(self):
        self.assertEqual(removeWord.remove_word_from_sentence("", "Papa"), "")

    def test_word_empty(self):
        self.assertEqual(removeWord.remove_word_from_sentence("Papa is a good guy", ""), "Papa is a good guy")


if __name__ == '__main__':
    unittest.main()