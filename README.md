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
