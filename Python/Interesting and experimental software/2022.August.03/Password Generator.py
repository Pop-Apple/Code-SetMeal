import string
import secrets

def password(size=12):
    chars = string.ascii_uppercase + string.ascii_lowercase + string.digits

# No (%&$#)


    return ''.join(secrets.choice(chars) for x in range (size))

               #Password Count 1 ~ ∞
print(password(6))