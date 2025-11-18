# 🚗 Garage App – Informatica Project

**Auteurs:** Jelte, Remco & Joachim  

---

## 📋 Opdracht Samenvatting

Ontwikkel een **garageprogramma** waarmee medewerkers eenvoudig gegevens van auto’s kunnen opvragen en beheren.  
Het programma moet werken met meerdere filialen, elk met een eigen voorraad en informatie.

---

## ⚙️ Functionaliteiten

### 🔹 Auto’s
Elke auto heeft de volgende eigenschappen:
- **Merk**
- **Model**
- **Kleur**
- **Aantal deuren** (`int`)
- **Vraagprijs** (`float`)
- **Afbeelding** (`img`)

### Methoden
| Methode | Beschrijving |
|----------|---------------|
| `geefNaam()` | Retourneert de combinatie *merk + model* |
| `heeftAfbeelding()` | Retourneert *true* of *false* |
| `updateVraagprijs()` | Wijzigt de vraagprijs van de auto |
| `toonVraagprijs()` | Geeft de prijs weer als *double*, afgerond op 2 cijfers |
| `toString()` | Retourneert de output van `geefNaam()` (opdracht is hier wat vaag over) |

---

## 🏢 Filialen
Het programma ondersteunt **meerdere garagelocaties**, elk met:
- Locatiegegevens (adres, telefoonnummer, eigenaar, etc.)
- Een eigen **inventaris** aan auto’s

Bij het inleveren moeten **minstens 3 locaties** zijn ingeprogrammeerd, elk met een bestaande voorraad.

---

## 🧭 Navigatie & Interface
- Een **menubalk** met onder andere:
  - Medewerkersinformatie aanpassen  
  - Wisselen tussen filialen  
- Een **statistiekenscherm** met:
  - Gemiddelde vraagprijs per filiaal  
  - Totale waarde van de voorraad  

---

## 💾 Gegevensopslag
- Bij **afsluiten** worden alle gegevens opgeslagen in een `.txt`-bestand  
- Bij **opstarten** controleert het programma of opslagbestanden bestaan en laadt deze automatisch  

---

## 🛠️ CRUD-functionaliteit
Gebruikers moeten:
- Nieuwe auto’s en filialen kunnen **toevoegen**
- Bestaande kunnen **aanpassen**
- En eventueel **verwijderen**

---

## ✅ Samenvatting van de eisen
- [x] 3 garagelocaties met bestaande voorraad  
- [x] Auto’s met de genoemde eigenschappen  
- [x] CRUD-functionaliteit voor auto’s en filialen  
- [x] Menu en statistiekenweergave  
- [x] Opslaan en laden van data via `.txt`-bestanden  
