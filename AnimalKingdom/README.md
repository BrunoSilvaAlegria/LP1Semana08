``` mermaid

      ---
      title: LP1 Diagram by Bruno Alegria
      ---

      classDiagram
      class Animal {          
      }

      class Dog {    
      }

      class Cat {
      }

      class Bat {
      }

      class Bee {
      }

      class IMammal {
            <<interface>> 
      }

      class ICanFly {
            <<interface>> 
      }

      class Program {
      }

      Animal *--> Program
      Animal <|-- Dog
      Animal <|-- Cat
      Animal <|-- Bat
      Animal <|-- Bee
      IMammal <|.. Dog
      IMammal <|.. Cat
      IMammal <|.. Bat
      ICanFly <|.. Bat
      ICanFly <|.. Bee
```