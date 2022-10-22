import re
from secrets import choice
from ssl import OPENSSL_VERSION_INFO
from urllib import robotparser
Bar = "-----------------"

print(Bar)
print("Simple Calculator")
print(Bar)

num1 = int(input("Enter the First Number: "))
num2 = int(input("Enter the Second Number: "))
print(Bar)

print("1, +")
print("2, -")
print("3, *")
print("4, /")

Selected = input("Enter the Selected Number: ")

if Selected == '1':
    print(num1 + num2)

if Selected == '2':
    print(num1 - num2)

if Selected == '3':
    print(num1 * num2)

if Selected == '4':
    print(num1 / num2)

print(Bar)