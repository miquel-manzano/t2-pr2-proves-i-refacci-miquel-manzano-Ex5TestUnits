# Dobles de Prova

Els dobles de prova (o test doubles en anglès) són objectes utilitzats en proves unitàries per simular el comportament d'objectes reals amb l'objectiu de controlar l'entorn de prova i aïllar el codi que s'està provant. Això permet verificar el funcionament d'una unitat de codi sense dependències externes com bases de dades, serveis web o altres components

## Tipus de Dobles de Prova
- Stubs: Objectes que proporcionen dades predefinides o comportaments per a mètodes en les proves, sense lògica complexa
- Mocks: Objectes que no només simulen el comportament, sinó que també registren les interaccions per verificar si es criden correctament.
- Spies: Similar als mocks, però permeten inspeccionar les crides després de l'execució del codi.
- Fakes: Implementacions simplificades de lògica que imiten el comportament d'objectes reals
- Dummy Objects: Implementacions simplificades de lògica que imiten el comportament d'objectes reals.

// podriamos entrar en mas detalle en los tipos y falta el ejemplo de uso en una solucion de C#