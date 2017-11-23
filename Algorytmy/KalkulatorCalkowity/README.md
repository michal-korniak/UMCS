# Kalkulator Całkowity

Zadanie polega na napisaniu kalkulatora, który będzie obliczał wyrażenia matematyczne na liczbach całkowitych zapisane w notacji nawiasowej.

Dopuszczalne operacje, wraz z priorytetami działań: 
Operator	Priorytet	Znaczenie
+	1	dodawanie
~	1	odejmowanie
*	2	mnożenie
d	2	dzielenie całkowite (div) liczby nieujemnej przez dodatnią
m	2	reszta z dzielenia całkowitego (mod) liczby nieujemnej przez dodatnią
^	3	potęgowanie całkowite (bez ujemnego wykładnika)
Dodatkowo w wyrażeniach można używać kilku rodzajów nawiasów: 
(	)
[	]
{	}
Poza wyżej wymienionymi operatorami kalkulator może oczywiście przyjmować liczby całkowite: ujemne ze znakiem -, dodatnie bez znaku (aby nie mieszać + z operatorem dodawania).

W rozwiązaniu wolno założyć, że każdy z elementów wprowadzonego wyrażenia będzie poprawny, a także, że między każdymi dwoma elementami będzie stać znak biały (spacja). Nie wiemy natomiast nic na temat poprawności (sensowności) wyrażenia i program powinien sprawdzać, czy wprowadzone do kalkulatora wyrażenie ma sens.

Wejście

W pierwszej linii wejścia znajduje się liczba n (1 ≤ n ≤ 100000) oznaczająca liczbę elementów wyrażenia.
W drugiej linii znajdują się kolejne elementy wyrażenia (operatory lub liczby) rozdzielone znakami białymi.
Wyjście

Na wyjściu należy wypisać:
 bledne nawiasy 
- komunikat oznaczający błędne ułożenie nawiasów względem siebie (np. nawias zamykający nie otwarty, niedomknięty nawias otwierający, przecinające się pary nawiasów różnych typów)
 bledna skladnia 
- komunikat oznaczający błąd w składni wyrażenia (np. dwie liczby obok siebie, dwa operatory obok siebie, pusta zawartość nawiasów, itd.)
 bledne dzialanie 
- komunikat oznaczający działanie, którego nie można wykonać (np. dzielenie przez liczbę <= 0, ujemny wykładnik, 0 do potęgi 0) 

jedną liczbę, która jest wynikiem obliczeń dla poprawnego wyrażenia
Sprawdzanie poprawności należy wykonać w kolejności powyższej listy. To znaczy: najpierw sprawdzić ułożenie wszystkich nawiasów względem siebie - jeśli jest błędne, program nie sprawdza kolejnych elementów. Następnie, o ile nawiasy są dobrze ustawione, należy sprawdzić składnię wyrażenia. Błędne działanie może zostać wykryte w trakcie obliczania wartości wyrażenia.

Warunki, które powinno spełniać rozwiązanie

Należy wykorzystać Odwrotną Notację Polską - przepisać wyrażenie do tej postaci, a następnie obliczyć jego wartość.
Rozwiązanie należy oprzeć na WŁASNYCH IMPLEMENTACJACH liniowych struktur danych (listy, kolejki, stosy) - tych elementów nie można importować z bibliotek.
Można założyć, że każda wprowadzona liczba oraz każda wartość obliczeń (w tym pośrednich) zmieści się w typie całkowitym 8 bajtowym.
Przykłady


	  4
	  ( ( 1 )
wynik:  bledne nawiasy

	  7
	  [ ( 1 + 1243 ] )
wynik:  bledne nawiasy

	  7
	  [ ( ~ + * ] )
wynik:  bledne nawiasy

	  2
	  1 1
wynik:  bledna skladnia

	  6
	  [ 1 * ] + 1
wynik:  bledna skladnia

	  9
	  [ 2 ~ 1 * 2 ] ^ 0
wynik:  bledne dzialanie		

	  13       
	  ( [ 1 + 1 ] * -2 ) ^ 2 + 5
wynik:  21
