#  File: Ciphers.py
#  Description: Decipher using plaintext, ciphertext, and keys.
#  Student's Name: Steve Lomeli
#  Student's UT EID: srl2629
#  Course Name: CS 303E 
#  Unique Number: 50180
#
#  Date Created: 4/8/20
#  Date Last Modified: 4/9/20

#Encode function
def encode(plaintext, key):
    change = 0
    cipher = ""
    alphabetString = 'a b c d e f g h i j k l m n o p q r s t u v w x y z'

    alphabet = list(alphabetString.split(" "))

    keyList = []
    for char in key:
        keyList.append(char)
    
    for char in plaintext:
        if char.isupper() == True:
            change += 1
            char = char.lower()
            
        if char in alphabet:
            num = alphabet.index(char)
            char = char.replace(char,key[num])
            
        if change == 1:
            char = char.upper()
            change = 0
        cipher += char
        
    return cipher

#Decode function
def decode(ciphertext, key):
    change = 0
    plaintext = ""
    alphabetString = 'a b c d e f g h i j k l m n o p q r s t u v w x y z'

    alphabet = list(alphabetString.split(" "))

    keyList = []
    for char in key:
        keyList.append(char)
    
    for char in ciphertext:
        if char.isupper() == True:
            change += 1
            char = char.lower()
            
        if char in keyList:
            num = keyList.index(char)
            char = char.replace(char,alphabet[num])
            
        if change == 1:
            char = char.upper()
            change = 0
        plaintext += char

    return plaintext

def main():

    #Given data
    plaintextMessages = [
        ["This is the plaintext message.",
         "bcdefghijklmnopqrstuvwxyza"],
        ["Let the Wookiee win!",
         "epqomxuagrdwkhnftjizlcbvys"],
        ["Baseball is 90% mental. The other half is physical.\n\t\t- Yogi Berra",
         "hnftjizlcbvysepqomxuagrdwk"],
        ["I used to think I was indecisive, but now I'm not too sure.",
         "mqncdaigyhkxflujzervptobws"],
        ["Einstein's equation 'e = mc squared' shows that mass and\n\t\tenergy are interchangeable.",
         "bludcmhojaifxrkzenpsgqtywv"] ]

    codedMessages = [
        ["Uijt jt uif dpefe nfttbhf.",
         "bcdefghijklmnopqrstuvwxyza"],
        ["Qnhxgomhqm gi 10% bnjd eho 90% omwlignh. - Zghe Xmy",
         "epqomxuagrdwkhnftjizlcbvys"],
        ["Ulj njxu htgcfj C'gj jgjm mjfjcgjt cx, 'Ep pej jyxj veprx rlhu\n\t\t uljw'mj tpcez jculjm'. - Mcfvw Zjmghcx",
         "hnftjizlcbvysepqomxuagrdwk"],
        ["M 2-wdme uxc yr kylc ua xykd m qxdlcde, qpv wup cul'v gmtd mlw\n\t\t vuj aue yv. - Hdeew Rdyladxc",
         "mqncdaigyhkxflujzervptobws"] ]

    #Plain text messages
    for i, j in plaintextMessages:
        encodedMessage = encode(i, j)
        print(format("plaintext:","<12s"), i)
        print(format("encoded:","<12s"), encodedMessage)
        redecodedMessage = decode(encodedMessage, j)
        print(format("re-decoded:","<12s"), redecodedMessage)
        print()

    #Coded messages
    for i, j in codedMessages:
        decodedMessage = decode(i, j)
        print(format("encoded:","<9s"), i)
        print(format("decoded:","<9s"), decodedMessage)
        print()


main()
