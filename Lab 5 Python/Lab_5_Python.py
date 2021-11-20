for a in range(10, 100):
   d1 = a // 10
   d2 = a % 10
   for b in range(10, 100):
       d3 = b //10
       d4 = b % 10
       check = d4 != d3 and d4 != d2 and d4 != d1 and d3 != d2 and d3 != d1 and d2 != d1
       if check:
           print(d1 * 1000 + d2 * 100 + d3 * 10 + d4)
       
