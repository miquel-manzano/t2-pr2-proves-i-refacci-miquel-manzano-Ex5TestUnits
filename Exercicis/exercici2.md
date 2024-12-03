# Dobles de Prova

Els dobles de prova (o test doubles en anglès) són objectes utilitzats en proves unitàries per simular el comportament d'objectes reals amb l'objectiu de controlar l'entorn de prova i aïllar el codi que s'està provant. Això permet verificar el funcionament d'una unitat de codi sense dependències externes com bases de dades, serveis web o altres components

## Tipus de Dobles de Prova
- Stubs: Objectes que proporcionen dades predefinides o comportaments per a mètodes en les proves, sense lògica complexa
- Mocks: Objectes que no només simulen el comportament, sinó que també registren les interaccions per verificar si es criden correctament.
- Spies: Similar als mocks, però permeten inspeccionar les crides després de l'execució del codi.
- Fakes: Implementacions simplificades de lògica que imiten el comportament d'objectes reals
- Dummy Objects: Implementacions simplificades de lògica que imiten el comportament d'objectes reals.

## Quan Utilitzar Cada Tipus

- Dummy: Quan una dependència és necessària però irrellevant per a la prova.
- Stub: Quan cal retornar dades predefinides.
- Mock: Quan s’han de verificar interaccions específiques.
- Spy: Quan es vol inspeccionar el comportament sense alterar la lògica.
- Fake: Quan es necessita una versió simplificada del sistema.

## Beneficis

- Aïllament: Evita la dependència de components externs com bases de dades o APIs.
- Rapidesa: Les proves s'executen més ràpidament en no dependre d'operacions externes.
- Predictibilitat: En simular el comportament dels components, s'eliminen factors externs que poden introduir incertesa.



# Bibliografía

Autor desconegut (09/11/2024). [Test double. Wikipedia](https://en.wikipedia.org/wiki/Test_double).

Autor desconegut (17/01/2024). [Objeto simulado. Wikipedia](https://es.wikipedia.org/wiki/Objeto_simulado).

Autor desconegut (31/05/2024). [Method stub. Wikipedia](https://en.wikipedia.org/wiki/Method_stub).

Autor desconegut (05/07/2024). [Mock object. Wikipedia](https://en.wikipedia.org/wiki/Mock_object).

Niegowski, T. (26/10/2023). [Mocks, stubs and spies in unit testing based on Mockito. j-labs](https://www.j-labs.pl/en/tech-blog/mocks-stubs-and-spies-in-unit-testing-based-on-mockito/).

Autor desconegut/varis (last 5 months ago) [What's the difference between faking, mocking, and stubbing?. Stackoverflow](https://stackoverflow.com/questions/346372/whats-the-difference-between-faking-mocking-and-stubbing).