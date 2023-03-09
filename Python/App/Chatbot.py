import nltk
from nltk.chat.util import Chat, reflections
nltk.download('punkt')
nltk.download('averaged_perceptron_tagger')
nltk.download('vader_lexicon')

pairs = [
    (r'hi|hello|hey', ['Hi there','Hello']),
    (r'What is your name?', ['My name is Chatbot','I am a chatbot']),
    (r'How are you?', ['I am doing great, thank you!','I am not feeling well today, but I am still here to chat with you.']),
    (r'bye|goodbye|see you', ['Goodbye','Take care']),
]

chatbot = Chat(pairs, reflections)
chatbot.converse()