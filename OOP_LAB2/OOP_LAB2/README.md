### Лабораторная работа 2. Тема: Управление инвентарем в ролевой игре 
**Выполнил Авдиенко Данила (464919)**

### SOLID
S - Single Responsibility Principle \
Item + наследники отвечают только за хранение информации об объекте инвентаря \
Inventory отвечает только за хранение предметов и контроль веса \
Damage/DefenseUpgrade отвечают только за изменение характеристик предметов \
WeaponBuilder отвечает только за создание оружия \
ItemFactory отвечает только за создание предметов

O - Open/Closed Principle \
Новые типы предметов добавляются через новые наследники Item без изменения логики Inventory \
Новые улучшения добавляются через новые классы, реализующие IUpgradeInstructions, без изменения существующих классов 

L - Liskov Substitution Principle \
Во всех местах, где используется Item (например, в Inventory), можно подставить любой его наследник (Weapon, Armor, Potion, QuestItem) без изменения логики 

I - Interface Segregation Principle \
Интерфейсы разделены по ролям: IEquippable только для экипируемых предметов, IUsable только для используемых
\
IUpgradeInstructions описывает только логику улучшений, IWeaponBuilder — только построение оружия, IItemFactory — только создание предметов 

D - Dependency Inversion Principle \
Код опирается на абстракции: улучшения работают через IUpgradeInstructions, создание предметов — через IItemFactory, создание оружия — через IWeaponBuilder 
\

### Паттерны проектирования

Strategy \
Strategy реализован через интерфейс IUpgradeInstructions и классы DamageUpgrade, DefenseUpgrade. \

Builder \
Паттерн Builder реализован через интерфейс IWeaponBuilder и класс WeaponBuilder. \
Оружие создаётся по шагам

Abstract Factory \
Паттерн Abstract Factory реализован через интерфейс IItemFactory и класс ItemFactory. \
Создание Weapon, Armor, Potion и QuestItem вынесено в фабрику, что дает возможность создавать предметы через единый интерфейс и не зависеть от конкретных конструкторов
