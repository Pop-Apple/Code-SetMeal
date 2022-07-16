def collatz(number):
    if number % 2 == 0:
        return int(number / 2)
    elif number % 2 == 1:
        return int(3 * number + 1)

print('Please complete the integer input')
number = int(input())


while collatz(number) != 1:
    collatz(number)
    number = collatz(number)
    print(number)
