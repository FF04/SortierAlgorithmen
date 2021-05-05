FF - Fabian Fried - 3BHIF - SortierAlgorithmen - 3.4.2021
=====================================================

Präsentation von Sortier-Algorithmen
da es sehr viele Arten von Sortier-Algorithmen gibt, nehme ich die "beliebtesten" 4

- Quicksort
	extrem effizient
	effizientester Sortieralgorithmus
	nimmt ein zufälliges privot element und gibt alle elemente die kleiner sind auf eine seite und alle die größer sind auf die andere
	wiederholt sich so lange bis sortiert
	Im schlechtesten fall ist das Privotelement immer das größte/kleinste (sehr unwahrscheinlich)

- Bubblesort
	Wird gerne verwendet da leicht zu erklären
	Die Großen Werte gehen wie Blasen nach oben
	es werden immer 2 gesappt
	Bester fall: einmal alles durchrennen (n)
	Schlechtester fall: Alles so oft durchrennen wie es elemente gibt (n^2)

- Insertionsort
	Ähnlich wie Bubblesort, aber effizienter
	Hier geht man nicht 100x den selben weg und tauscht immer die 2, welche ungleich sind
	sondern sobald 2 ungleich sind, bringt man den kleineren wert bis ganz nach unten

- Bogosort
	uneffizientester algorythmus
	Alle elemente werden einfach zufällig aneinandergereit bis durch zufall alles richtig ist
	Es kann der schnellste und langsamste Weg sein
	Im besten Fall ist nach nur einem einzigen mal vertauschen alles richtig
	Im Schlechtesten (n*n!) beispiel n = 3    3*3!  = 3*3*2*1 = 10
	Also bei einer Liste von 1_000_000 Elementen währe das (nahezu) unendlich 


















Sachen aus dem Internet:
Es wurde KEIN Code gecopied oder abgeschrieben, zur funktionsweiße von Algorithmen habe ich nur grafiken und videos (ohne Code) angeschaut
















    int width = SortPanel.Width;
            int sizeperElement = (int)Math.Floor((double)width / (double)items.Count);
            int MaxValue = items.Max();

             pg = SortPanel.CreateGraphics();

            pg.FillRectangle(new SolidBrush(Color.Gray),0,0,items.Count,MaxValue);


            for (int i = 0; i < items.Count; i++)
            {
                pg.FillRectangle(new SolidBrush(Color.Black), i, MaxValue-items[i], sizeperElement, MaxValue);

            }