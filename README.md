# hackaton_teamchleb

Witam witam to notatki Krzysia na temat enigmy NIE DOTYKAĆ BO KURWA ZABIJE

UWAGI:
1. Używane rotory od lewej do prawej to I, II, III (później możliwość zmiany rotorów). Sygnał jako pierwszy przechodzi przez rotor prawy, czyli rotor III, potem II, a na końcu I.
2. Potem sygnał wysyłany jest z powrotem przesyłany przez rotory, tym razem od lewej do prawej (I - III). Pamiętać że kodowanie jest odwrotne (zamiast podporządkowywać np. EKM... do ABC..., przyporządkowujemy ABC... do EKM...)!!!
3. Rotory mają pozycje od 1 do 26
4. Kiedy rotor I zmienia pozycję z Q na R to porusza kolejny rotor, rotor 2 przy zmianie z E na F, rotor 3 przy zmianie z V na W
5. Rotory standardowo zmieniają litery odpowiednio ABCDEFGHIJKLMNOPQRSTUVWXYZ na:
- rotor I - EKMFLGDQVZNTOWYHXUSPAIBRCJ
- rotor II - AJDKSIRUXBLHWTMCQGZNPYFVOE
- rotor III - BDFHJLCPRTXVZNYEIWGAKMUSQO
- rotor IV - ESOVPZJAYQUIRHXLNFTGKDCMWB
- rotor V - VZBRGITYUPSDNHLXAWMJQOFECK
6. Po każdym obrocie rotora zamiana zmienia się np. po pierwszym wpisaniu w pierwszym rotorze A zmieni się na E, a po drugim A-K, trzeim A-M itd.
7. Ring position zmienia offset między wejściem a wyjściem z rotora. Działa na podobnej zasadzie co ruch rotora tzn. jeśli ring position jest 1 (zakładając że rotor jest I oraz rotor position to 1) to A zmieni się na E, a jeśli ring position jest 2, to A zmieni się na K (zgodnie z punktem 5)
8. Entry wheel zmienia litery ABCDEFGHIJKLMNOPQRSTUVWXYZ odpowiednio na QWERTZUIOPASDFGHJKLYXCVBNM
9. Reflektor zmienia litery podobnie jak plugboard, każda litera musi być połączona z inną

Działanie krok po kroku:
1. Użytkownik wciska klawisz
2. Sygnał przechodzi przez plugboard
3. Entry wheel zamienia literę jak napisałem wyżej
4. Sygnał przekazywany jest dalej do wirników (my użyjemy tych typu I, II oraz III, ewentualnie potem dodamy opcję zmiany na inne) 
5. Reflektor zmienia literę jak napisałem wyżej
6. Sygnał wraca przez rotory
7. Sygnał trafia do plugboarda gdzie zmienia jedną literę (tą, która wyszła z rotora) na inną (w zależności od podpięcia)
8. Finalna litera jest wyświetlana

Powodzenia przyszły ja
