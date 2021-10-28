import math

n = int(input("Enter your number:"))
result = float(0)
sum = float(0)
for i in range(1,n+1):
    sum = sum + math.sin(0.5)/i/i
result = 1/sum
print(result)
