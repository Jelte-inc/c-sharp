# 🚗 CheraasjeEpp – Garage Management Systeem

**Auteurs:** Jelte, Remco & Joachim

---

## 📖 Beschrijving
**CheraasjeEpp** is een uitgebreide Windows Forms-applicatie voor het beheren van een autogarageketen. Het systeem stelt medewerkers en beheerders in staat om de voorraad, filialen en gebruikers efficiënt te beheren. In plaats van eenvoudige tekstbestanden, maakt deze applicatie gebruik van een robuuste **SQLite-database** voor veilige en betrouwbare gegevensopslag.

De applicatie is ontworpen met een moderne, consistente gebruikersinterface en biedt functionaliteit voor zowel dagelijks gebruik als administratief beheer.

---

## 🚀 Functionaliteiten

### 🔹 Login & Beveiliging
- **Veilige inlog:** Gebruikers loggen in met een uniek ID en wachtwoord.
- **Rolgebaseerde toegang:** Onderscheid tussen standaard medewerkers en beheerders (Admins).

### 🔹 Vlootbeheer (Fleet)
- **Overzicht:** Bekijk de volledige autovoorraad per filiaal.
- **Filteren & Zoeken:** Uitgebreide filteropties op:
  - Merk & Model
  - Prijsklasse
  - Kleur
  - Aantal deuren
- **Details:** Bekijk gedetailleerde informatie per auto, inclusief specificaties en afbeeldingen.

### 🔹 Filiaalbeheer
- **Locatie-informatie:** Bekijk adresgegevens, telefoonnummers en eigenaren van filialen.
- **Openingstijden:** Inzage in de openingstijden per vestiging.

### 🔹 Administratie (Admin Only)
- **Gebruikersbeheer:** Toevoegen, wijzigen en verwijderen van gebruikersaccounts.
- **Filiaalbeheer:** Beheren van filialen (toevoegen, aanpassen, verwijderen).
- **Auto Beheer:** Nieuwe auto's toevoegen aan de voorraad (inclusief afbeeldingen) of verkochte auto's verwijderen.

---

## 💻 Technische Details
- **Framework:** .NET 8.0 (Windows Forms)
- **Taal:** C#
- **Database:** SQLite (`database.db`)
- **Architectuur:**
  - Scheiding tussen **Data**, **Models**, en **UI** (User Interface).
  - Gebruik van custom UI widgets (zoals `RoundedButton`, `RoundedTextBox`) voor een moderne 'look & feel'.

---

## 🛠️ Installatie & Gebruik
1. Clone de repository.
2. Open de oplossing (`.sln`) in Visual Studio.
3. Zorg dat de `database.db` aanwezig is in de `Data` map (deze wordt standaard meegeleverd in de build output).
4. Start de applicatie via `F5` of de "Start" knop.

---

## ✅ Status
Dit project voldoet aan de eisen van de opdracht en is verder uitgebreid met persistentie via een database en een verbeterde gebruikerservaring.
