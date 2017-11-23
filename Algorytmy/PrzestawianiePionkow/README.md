# Przestawianie Pionków 
Dany jest graf nieskierowany o n wierzchołkach i m krawędziach oraz dwa pionki p1 i p2 ustawione w zadanych wierzchołkach. Dodatkowo mamy zadany ciąg wierzchołków, które należy odwiedzić.

Zadanie polega na takim przestawieniu pionków p1 i p2 aby odwiedzić wierzchołki z zadanego ciągu we wskazanej kolejności pokonując jak najkrótszą drogę.

Przy czym jeśli okaże się, że oba pionki mają tak samo daleko do zadanego wierzchoła v to ruszyć powinien się ten, który ostatnio pozostawał bez ruchu. Jeśli natomiast do wierzchołka v nie będzie mógł się dostać ani 1 ani 2 pionek wówczas program ma wyświetlić komunikat: "Brak połączenia z wierzchołkiem v" i zakończyć działanie.

Struktura umożliwiająca realizację tego zadania to graf oraz ewentualnie lista liniowa, kolejka. Należy samodzielnie zaimplementować te struktury.

UWAGA: Nie można wykorzystywać gotowych struktur i algorytmów.

Wejście:

W pierwszej linii wejścia znajduje się n - liczba wierzchołków grafu;
W drugiej linii wejścia znajduje się m - liczba krawędzi grafu;
W kolejnych m liniach znajdują się oddzielone spacjami pary wierzchołków u, v definiujące kolejne krawędzie;
W przedostatniej linii znajdują się oddzielone spacją pionki p1, p2;
W ostatniej linii znajduje się liczba wierzchołków zadanego ciągu oraz wierzchołki tego ciągu oddzielone spacjami;
Wyjście:

Na wyjściu wyświetlamy oddzielone spacjami numery pionków, w kolejności w jakiej były przestawiane.

Przykład 1

Wejście:

6
7
0 1
0 3
1 4
3 4
4 2
2 5
4 5
3 5
3 5 1 2
Wyjście:

2 1 2  
Przykład 2

Wejście:

8
10
0 1
1 2
0 3
3 4
3 5
4 6
4 5
5 6
5 7
6 7
0 6
7 2 7 4 0 2 5 1
Wyjście:

1 2 2 1 1 2 1 
