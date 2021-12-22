def funk (str, k):
    i = 0
    number = 0
    while i < len(str):
        number = (int)(str. find(" ", i)) if (int)(str.find(" ",i)) > 0 else len(str)
        if (number - i < k):
            print(str[i: number])
        i = number + 1;

str = input("Enter string: ")
k = (int)(input("Enter k: "))
funk(str, k)