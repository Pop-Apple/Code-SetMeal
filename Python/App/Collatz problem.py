def collatz(number):
    if number % 2 == 0:
        return int(number / 2)
    elif number % 2 == 1:
        return int(3 * number + 1)

print('**コラッツの問題**'+'\n')

number = int(input('：'))

print('')


while collatz(number) != 1:
    collatz(number)
    number = collatz(number)
    print(number)
    
print('1'+'\n')

input()