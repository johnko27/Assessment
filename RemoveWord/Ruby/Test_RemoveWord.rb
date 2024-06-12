require_relative "RemoveWord"
require "test-unit"

class RemoveWordTest < Test::Unit::TestCase
    def test_punc_one
        assert_equal(remove_word.remove_word_from_sentence("Papa is a good guy.", "good"), "Papa is a guy")
    end

    def test_punc_two
        assert_equal(remove_word.remove_word_from_sentence("Papa is a good guy", "good"), "Papa, is a guy")
    end

    def test_one_word
        assert_equal(remove_word.remove_word_from_sentence("Papa is a good guy", "good"), "Papa is a guy")
    end

    def test_multiple_words
        assert_equal(remove_word.remove_word_from_sentence("Papa good is a good guy", "good"), "Papa is a guy")
    end

    def test_spaces
        assert_equal(remove_word.remove_word_from_sentence("Papa is a  good guy", " "), "Papa is a good guy")
    end

    def test_strip
        assert_equal(remove_word.remove_word_from_sentence("Papa is a good guy ", "good"), "Papa is a guy")
    end
    
    def test_trail
        assert_equal(remove_word.remove_word_from_sentence("Papa is a good guy", "Papa"), "is a good guy")
    end

    def test_in
        assert_equal(remove_word.remove_word_from_sentence("Papagood is a good guy", "good"), "Papagood is a guy")
    end

    def test_case
        assert_equal(remove_word.remove_word_from_sentence("Papa is a goOd Good guy", "good"), "Papa is a guy")
    end

    def test_sentence_empty
        assert_equal(remove_word.remove_word_from_sentence("", "Papa"), "")
    end

    def test_word_empty
        assert_equal(remove_word.remove_word_from_sentence("Papa is a good guy", ""), "Papa is a good guy")
    end
end