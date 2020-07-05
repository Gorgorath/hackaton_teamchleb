# hackaton_teamchleb

Witam witam to notatki Krzysia na temat enigmy NIE DOTYKAĆ BO KURWA ZABIJE

UWAGI:
1. Używane rotory od lewej do prawej to I, II, III (później możliwość zmiany rotorów). Sygnał jako pierwszy przechodzi przez rotor prawy, czyli rotor III, potem II, a na końcu I.
2. Potem sygnał wysyłany jest z powrotem (jeżeli z lewego rotoru wyszła litera np. M, to z reflektoru wychodzi litera o 13 dalej (połowa z 26), czyli Z i przechodzi z powrotem przez rotory, tym razem od lewej do prawej (I - III))
3. Rotory mają pozycje od 1 do 26
4. Kiedy rotor I zmienia pozycję z Q na R to porusza kolejny rotor, rotor 2 przy zmianie z E na F, rotor 3 przy zmianie z V na W
5. Rotory standardowo zmieniają litery odpowiednio ABCDEFGHIJKLMNOPQRSTUVWXYZ na:
- rotor I - EKMFLGDQVZNTOWYHXUSPAIBRCJ
- rotor II - AJDKSIRUXBLHWTMCQGZNPYFVOE
- rotor III - BDFHJLCPRTXVZNYEIWGAKMUSQO
- rotor IV - ESOVPZJAYQUIRHXLNFTGKDCMWB
- rotor V - VZBRGITYUPSDNHLXAWMJQOFECK
Po każdym obrocie rotora zamiana zmienia się np. po pierwszym wpisaniu w pierwszym rotorze A zmieni się na E, a po drugim A-K, trzeim A-M itd.

Działanie krok po kroku:
1. Użytkownik (niżej U) wciska klawisz (przykładowo A)
2. Sygnał przekazywany jest dalej do wirników (my użyjemy tych typu I, II oraz III, ewentualnie potem dodamy opcję zmiany na inne) 
3. Reflektor odwraca sygnał jak napisałem wyżej
4. Sygnał wraca przez rotory
5. Sygnał trafia do plugboarda gdzie zmienia jedną literę (tą, która wyszła z rotora) na inną (w zależności od podpięcia)
6. Finalna litera jest wyświetlana

Powodzenia przyszły ja
