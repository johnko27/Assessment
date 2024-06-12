import sys
import re

def remove_word_from_sentence(sentence, word):
    # return nothing if no sentence
    if not sentence:
        return sentence
        
    sentence = remove_multiple_spaces(sentence)

    # return sentence to word is empty
    if not word: 
        return sentence
    
    # remove punctuation
    sentence = re.sub(r'[^\w\s]', '', sentence)
    
    # case insensitive replacement
    word_list = sentence.split()
    new_words = list(filter(lambda w: w.lower() != word.lower(), word_list))
    sentence =" ".join(new_words)

    sentence = remove_multiple_spaces(sentence)

    return sentence.strip()

def remove_multiple_spaces(sentence):
    # remove all multiple spaces
    while sentence.find("  ") > -1:
        sentence = sentence.replace("  ", " ")
    return sentence