userInput = input('Please ener a number to see if it is a palindrome: ')
reversedString = userInput[::-1]


if userInput == reversedString:
    print("It is a palindrome!")
else:
    print("It is not a palindrome!")
