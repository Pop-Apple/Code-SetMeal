import sys
import os

def collatz(number):
    if number % 2 == 0:
        return int(number / 2)
    elif number % 2 == 1:
        return int(3 * number + 1)

TitleUp = '\n' + '【 コラッツの問題  |  Collatz Problem 】' + '\n'
print(TitleUp)

def ToDo():

    number = int(input('番号の入力：'))

    print('')

    while collatz(number) != 1:
        collatz(number)
        number = collatz(number)
        print(number)
    
    print('1'+'\n')
    ToDo()
ToDo()