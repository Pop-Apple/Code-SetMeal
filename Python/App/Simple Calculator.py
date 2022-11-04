import re
from secrets import choice
from ssl import OPENSSL_VERSION_INFO
from urllib import robotparser
import sys

def Caluc():

    print("シンプル電卓！"+'\n')

    num1 = int(input("Value1："))
    num2 = int(input("Value2："))

    print('')

    print("+ [1]"+"\n"+"- [2]"+"\n"+"x [3]"+"\n"+"/ [4]"+"\n")

    Selected = input("：")

    if Selected == '1':
        print('')
        print(num1 + num2)

    if Selected == '2':
        print('')
        print(num1 - num2)

    if Selected == '3':
        print('')
        print(num1 * num2)

    if Selected == '4':
        print('')
        print(num1 / num2)

    input()

Caluc()