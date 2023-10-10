# Kata Gilded Rose

Le Kata Gilded Rose est un exercice de refactoring de code populaire conçu pour améliorer la maintenabilité et la lisibilité du code existant. L'exercice consiste à prendre un ensemble de spécifications de gestion d'inventaire et à les implémenter dans un code existant, en veillant à ce que le code reste propre, extensible et compréhensible.

## Objectif

L'objectif principal du Kata Gilded Rose est de pratiquer les compétences de refactoring de code en utilisant un code de base existant qui nécessite des améliorations. Vous devez ajouter de nouvelles fonctionnalités à l'application tout en maintenant la qualité du code et en évitant la duplication.

## Contexte

Vous travaillez sur une application qui gère l'inventaire d'un magasin. L'inventaire comprend une variété d'articles, chacun ayant une date de péremption et une qualité associée. Vous avez la tâche de mettre en œuvre un système de mise à jour de l'inventaire pour suivre les spécifications de gestion d'inventaire suivantes :

1. Chaque jour, la qualité de chaque article diminue d'un point.

2. Une fois que la date de péremption d'un article est passée, la qualité diminue deux fois plus rapidement.

3. La qualité d'un article ne peut jamais être négative.

4. Certains articles ont des règles de qualité spéciales :
   - "Aged Brie" augmente en qualité à mesure qu'il vieillit.
   - "Sulfuras, Hand of Ragnaros" est un article légendaire qui ne change jamais de qualité et n'a pas de date de péremption.
   - "Backstage passes" augmentent en qualité avec le temps, mais la qualité augmente de 2 quand il reste 10 jours ou moins et de 3 quand il reste 5 jours ou moins. Une fois le concert passé, la qualité chute à zéro.

5. Vous pouvez ajouter de nouvelles règles pour de nouveaux types d'articles à tout moment.


## Exécution du program
Pour exécutez le programme à l'aide de la commande suivante :
```bash
dotnet run
```

## Exécution des tests

Pour exécuter les tests unitaires, utilisez la commande suivante dans votre terminal (assurez-vous que vous êtes dans le répertoire racine du projet) :

```bash
dotnet test
```

plus de détails.

## Ressources supplémentaires

- [Kata Gilded Rose sur GitHub](https://github.com/emilybache/GildedRose-Refactoring-Kata): Le dépôt officiel du Kata Gilded Rose avec des ressources supplémentaires et des solutions de référence.

- [Kata Gilded Rose sur Coding Dojo](https://codingdojo.org/kata/GildedRose/): Le Kata Gilded Rose sur le site Coding Dojo, avec des informations supplémentaires et des défis pour pratiquer.

Amusez-vous à travailler sur le Kata Gilded Rose et à améliorer vos compétences en refactoring de code ! Si vous avez des questions ou des suggestions, n'hésitez pas à les partager.

---
Ce README est basé sur le modèle fourni par [GitHub Docs](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/creating-a-repository-on-github/about-readmes).
