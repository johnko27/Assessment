class RemoveWord
    def remove_word_from_sentence(sentence, word)
        def remove_word(sentence, word)
            # return nothing if no sentence
            return sentence if sentence.empty?
          
            # remove all multiple spaces
            sentence = sentence.split.join(' ')
          
            # return sentence to word is empty
            return sentence if word.empty?
          
            # remove punctuation
            sentence = sentence.sub(/[^\w\s]/, '')

            # case insensitive replacement
            word_list = sentence.split(' ')
            sentence = word_list.reject! { |x| word.downcase == x.downcase }.join(' ')

            # remove all multiple spaces
            sentence = sentence.split.join(' ')

            # strip leading and trailing space
            sentence = sentence.strip
          
            sentence
          end
    end
end