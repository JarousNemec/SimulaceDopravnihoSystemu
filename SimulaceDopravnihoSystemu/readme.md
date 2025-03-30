# Package Delivery Simulator
- Tato aplikace simuluje běh dopravní spolešnosti. Je zde znázorněn pohyb dodávek, který je závislý na zásilkách v systému. Ze simulace může uživatel vidět, jak množstvý zásilek v různých depech ovlivňuje čas jejich doručení a čas doručování.
- Pro výpočet dráhy pohybu komponenty znázorňující dodávku je využit jednotkový vektor, který je následně vynásoben konstantou dle rychlosti dodávky. Tento vektor je použit pro výpočet posunutí za každý tick.
  - https://cs.wikipedia.org/wiki/Jednotkov%C3%BD_vektor
- Možná zlepšení:
  - Dodávky by nemusely vyjíždět pokud v systému není zadána žádná zásilka, pro kterou jedou.
  - Lepší manipulace s časem pro například zrychlení simulace.
  - Lepší textury jednotlivých komponent jako dodávky nebo staníce.
  - Znázornění času dopravy, nakládání a vykládání.