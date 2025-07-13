# 🃏 Huszonegy - Magyar kártyajáték
**Karakteres változat**
<br><br>

## Leírás
A Huszonegy egy magyar kártyajáték implementáció konzolos alkalmazásként. A játék célja, hogy a kézben levő kártyák összege megközelítse vagy elérje a 21-et anélkül, hogy túllépné azt.
<br><br>

## 🎲 Játékszabályok
- A kártyák összege törekedjen a 21-re, de ne lépje túl
- 16 összegű eredménynél már meg lehet állni, vagy lehet kockáztatni új kártyával
- Az ellenfél egy számítógépes robot
- A nagyobb összegű lap tulajdonosa nyer
- Egyenlő eredmény esetén az osztó nyer
- Ha az első két kártya összege 22 (11+11), az a "huszonegy Joker" és nyerő kombináció
<br><br>

## Nehézségi szintek

### 🟢 Könnyű
- A robot eredménye túllépheti a 22-t
- Te vagy az osztó

### 🟡 Közepes
- A robot eredménye maximum 4 számmal lépheti túl a 22-t
- Te vagy az osztó

### 🔴 Nehéz
- A robot eredménye 16-22 között lehet
- A robot az osztó
<br><br>

## Telepítés és futtatás

### Követelmények
- .NET Framework 4.8
- Windows operációs rendszer

### Alkalmazás
- Visual Studio 2017 vagy újabb (fejlesztéshez)
- A Release-ben található exe fájl (játékhoz)
<br><br>

## 🏗️ Projekt struktúra

```
huszonegy_karakteres/
├── huszonegy_karakteres/          # Fő alkalmazás
│   ├── Program.cs                 # Fő programlogika
│   ├── Properties/
│   │   └── AssemblyInfo.cs       # Assembly információk
│   ├── App.config                # Alkalmazás konfiguráció
│   └── packages.config           # NuGet csomagok
├── Tester/                       # Unit tesztek
│   ├── TesterClass.cs            # Teszt osztály
│   └── Tester.csproj            # Teszt projekt konfiguráció
└── README.md                     # Projekt dokumentáció
```
<br>

## ℹ️ Fejlesztési információk

### Használt technológiák
- **Nyelv**: C# (.NET Framework 4.8)
- **UI**: Cmd
- **Kódstílus**: StyleCop Analyzers
- **Fejlesztői környezet**: Visual Studio

### Készítő

- **Matula Márton**  
- Első változat: 2022. április 19. *v.0.1.0.0*
- Legutóbbi változat: 2025. július 13. *v.1.0.0.1*
<br><br>

---
*Ez a README az 2. release (v1.1.250713) alapján készült.*
