#create basic calculationg operations

def summa(a, b):
    return a + b

def erotus(a, b):
    return a - b

def tulo(a, b):
    return a * b

def jakolasku(a, b):
    if b == 0:
        raise ValueError("Nollalla jakaminen ei ole sallittua.")
    return a / b