def gcd(a, b):
    if(b == 0):
        return a
    return gcd(b, a%b)

def gcd3(a, b, c):
    return gcd(gcd(a, b), c)         

n = int(input("Enter n>0: "))

while(n <= 0):
    n = int(input("Enter n > 0!!!: "))

i = int(input("Enter i>0: "))

while(i <= 0):
    i = int(input("Enter i > 0!!!: "))

m = int(input("Enter m>0: "))

while(m <= 0):
    m = int(input("Enter m > 0!!!: "))

result = gcd3(n,i,m)
print(result)

