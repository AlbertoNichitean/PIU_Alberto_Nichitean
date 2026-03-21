# PIU_Alberto_Nichitean
Acest repository conține activitatea desfășurată la disciplina PIU.

Tema 1 - Calcul Salariu
Descriere: Aplicație de consolă care calculează salariul unui angajat.
Tipuri de date utilizate: int pentru numărul de ore și double pentru tariful pe oră.
Logica: Dacă salariul calculat depășește pragul de 3000 lei, se afișează mesajul "Salariu mare".

Proiect Principal (În lucru)

Tema aleasă: Închirieri Mașini.

Închirieri Mașini: Aplicația va fi folosită la un birou de închirieri. Aceasta va afișa o listă cu toate mașinile firmei respective. De asemenea, pentru a avea acces la aplicație, vor trebui folosite datele de conectare puse la dispoziție de firmă pentru fiecare angajat.
În momentul în care un client este interesat, vom putea vedea lista mașinilor disponibile. Închirierea se face pe bază de nume, prenume și CNP, pentru o perioadă anume (de la data de..., la data de...). Toate aceste date vor fi salvate în baza de date, în același timp mașina devenind indisponibilă pentru următorii clienți.


🛠️ Implementare și Structură (Etapa 1)

Am definit logica de business prin crearea a 4 clase principale, grupate în namespace-ul ProiectInchirieriAuto. Fiecare clasă dispune de constructori (implicit și cu parametri) și o metodă Info() pentru formatarea datelor.

Entitățile proiectului:
1. Masina: Gestionează datele tehnice (Marcă, Model, An, Nr. Înmatriculare) și starea de disponibilitate.
-Logic: La crearea unui obiect, mașina este setată automat ca fiind Disponibila.

2. Client: Stochează informațiile de identificare ale clientului (Nume, Prenume, CNP).

3. Angajat: Definește profilul utilizatorului care operează sistemul, incluzând credențialele de acces (Utilizator și Parolă).

4. ContractInchiriere: Reprezintă legătura dintre mașină și client.
-Logic: În momentul în care se instanțiază un contract, starea mașinii (EsteDisponibila) se schimbă automat în false.

🚀 Aplicația de Test (Program.cs)

În metoda Main, am implementat un scenariu complet de testare care execută următorii pași:

1. Afișează angajatul care a accesat sistemul.
2. Creează o mașină nouă și îi verifică starea inițială (Disponibilă).
3. Definește un client și înregistrează un contract de închiriere pe o perioadă de 7 zile.
4. Verifică actualizarea automată a stării mașinii (devine "Închiriată" după semnarea contractului).



🛠️ Evoluție și Restructurare: Gestiunea Colecțiilor (Laboratorul 3 & 4) (Etapa 2 & 3)

În această etapă, proiectul a evoluat de la o aplicație simplă de consolă la o soluție software modulară, integrând gestiunea dinamică a datelor și tehnologii avansate de interogare (LINQ). Implementarea acoperă simultan cerințele Laboratoarelor 3 și 4.

1. Arhitectura pe 3 Niveluri (Separation of Concerns)

Pentru o mentenanță ușoară și un cod curat, aplicația este acum divizată în 3 proiecte distincte:

-ModeleAuto (Librărie de clase): Conține entitățile de business (Masina, Client, Angajat, ContractInchiriere) și definirea enumerărilor.

-NivelStocareDate (Librărie de clase): Gestionează colecțiile de obiecte. Am implementat clasa AdministrareMasiniMemorie, care utilizează o colecție generică de tip List<Masina> pentru a înlocui vectorii statici, permițând o stocare dinamică în memoria RAM.

-ProiectInchirieriAuto (Proiect Consolă): Gestionează exclusiv interfața cu utilizatorul (Program.cs) și rutează comenzile.

2. Tipuri Avansate de Date și Validări (Lab 4)
   
Sistem de Enumerări:

-CuloareMasina: Enumerare simplă pentru definirea culorii mașinii (Roșu, Alb, Negru).

-OptiuniMasina: Enumerare implementată cu atributul [Flags]. Aceasta permite selecția multiplă de dotări (ex: AerConditionat | Navigatie) utilizând operatori pe biți.

-Tratarea Excepțiilor și Validare: Citirea datelor numerice de la tastatură (ex: Anul fabricației, Opțiunile) este securizată folosind metoda int.TryParse, prevenind închiderea accidentală a aplicației la introducerea unor caractere invalide.

3. Gestiunea Datelor și Tehnologia LINQ (Lab 3 & 4)

Logica aplicației permite acum realizarea operațiilor fundamentale asupra listei de mașini:

-Citirea și Salvarea: Adăugarea de noi obiecte de tip Masina de la tastatură și stocarea lor în colecția dinamică List<Masina>.

-Afișarea: Parcurgerea "vectorului" de obiecte și listarea formatată a flotei.

-Căutarea și Filtrarea (Integrare LINQ): Am înlocuit căutările clasice iterative cu LINQ (Language Integrated Query).

-Metoda CautaMasiniDupaMarca utilizează funcția de extensie .Where() pentru a găsi rapid mașinile.

-Funcția .FindAll() este utilizată pentru a extrage doar mașinile cu statusul EsteDisponibila = true.

4. Logica Interactivă (Meniul Principal)

Aplicația dispune de un meniu interactiv (tip consolă) care modelează fluxul real dintr-un birou de închirieri:

-L (Listare Flotă): Vizualizarea tuturor mașinilor înregistrate.

-D (Masini Disponibile): Afișarea exclusivă a vehiculelor care pot fi închiriate.

-I (Închiriere): Proces complet prin care se introduce un client nou (Nume, Prenume, CNP), se generează un ContractInchiriere și se schimbă automat statusul mașinii în "indisponibil".

-C (Citire): Introducerea unei mașini noi în flotă, cu specificarea culorii și a dotărilor multiple.
