import string
import secrets

def password(size=12):
    chars = string.ascii_uppercase + string.ascii_lowercase + string.digits
    return ''.join(secrets.choice(chars) for x in range (size))

print('作成 [1]'+'\n'+'終了 [2]'+'\n')

Command = input('：')

if Command == '1':
    PasswordValue = int(input('\n'+'文字数を入力してください：'))
    print('')

    print(password(PasswordValue))

    input()

if Command == '2':
    exit()

else:
    print('\n'+'エラー')