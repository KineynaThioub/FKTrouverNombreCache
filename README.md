# TP C# – Trouver le nombre caché

**Nom du projet :** FKTrouverNombreCache  
**Langage :** C#  
**Type d'application :** Application console

---

## Bonjour cher professeur,

Dans le cadre de ce devoir pratique, j'ai réalisé une application console en C# intitulée **FKTrouverNombreCache**.

L'objectif de ce programme est de proposer un jeu dans lequel l'utilisateur doit retrouver un nombre généré aléatoirement par l'application. Le jeu comporte deux niveaux de difficulté : un mode facile et un mode difficile.

Ce travail m'a permis de mettre en pratique plusieurs notions fondamentales du langage C#, notamment les conditions, les boucles, les méthodes, les collections, la génération de nombres aléatoires et la gestion des erreurs de saisie.

Vous trouverez ci-dessous les informations nécessaires pour comprendre, lancer et tester l'application.

## 1. Présentation du projet

L'application propose trois choix à l'utilisateur :

- **F – Facile :** trouver un nombre aléatoire compris entre 1 et 10.
- **D – Difficile :** définir soi-même les bornes minimale et maximale de l'intervalle. La différence entre les deux bornes doit être supérieure à 10.
- **Q – Quitter :** quitter le programme.

Le programme vérifie les saisies de l'utilisateur et affiche des messages explicatifs lorsqu'une valeur incorrecte est entrée.

## 2. Fonctionnalités réalisées

### Mode facile
- Génération aléatoire d'un nombre entre 1 et 10, bornes incluses.
- Demande d'un nombre à l'utilisateur.
- Vérification de la validité de la réponse.
- Affichage d'un message en cas de victoire ou de défaite.
- Affichage de la liste des réponses déjà proposées.
- Possibilité de quitter une partie avec la touche Q.

### Mode difficile
- Demande des bornes minimale et maximale.
- Vérification que les deux valeurs sont des nombres entiers.
- Vérification que la borne minimale est inférieure à la borne maximale.
- Vérification que la différence entre les deux bornes est supérieure à 10.
- Génération aléatoire du nombre caché dans l'intervalle choisi.
- Vérification des réponses proposées.

### Gestion des notes
- Comptabilisation du nombre d'essais valides.
- Calcul de la note en pourcentage après une victoire.
- Conservation de la meilleure note pendant toute la session.
- Affichage de la meilleure note lors de la fermeture du programme.

## 3. Notions C# utilisées

| Notion | Utilisation |
|---|---|
| `while` | Répéter les parties et les saisies |
| `if / else` | Vérifier les conditions |
| `Random` | Générer le nombre caché |
| `TryParse()` | Vérifier les saisies numériques |
| `List<int>` | Conserver les réponses du mode facile |
| `static` | Partager certaines données et méthodes |
| Méthodes | Organiser les différentes fonctionnalités |
| `Console.ReadLine()` | Lire les saisies utilisateur |
| `Console.Clear()` | Effacer l'écran |

## 4. Calcul de la note

La note est calculée selon la formule suivante :

**Note = ((Max - Min + 1 - Nombre d'essais) / (Max - Min + 1)) × 100**

Exemple :

Pour un intervalle de 1 à 10 avec 3 essais :

Note = ((10 - 1 + 1 - 3) / 10) × 100

**Note = 70 %**

La meilleure note obtenue est conservée jusqu'à la fermeture de l'application.

## 5. Gestion des erreurs

Plusieurs contrôles ont été intégrés afin d'éviter les erreurs pendant l'exécution :

- Refus des saisies non numériques lorsque le programme attend un nombre.
- Refus des nombres situés en dehors de l'intervalle autorisé.
- Vérification des bornes dans le mode difficile.
- Refus des intervalles invalides.
- Prise en charge de la touche Q pour quitter ou revenir au menu selon le mode de jeu.

## 6. Organisation du projet

Le projet est organisé de manière simple :

```text
FKTrouverNombreCache/
│
├── Program.cs
├── FKTrouverNombreCache.csproj
└── README.md
```

- **Program.cs :** contient le code source et la logique du jeu.
- **FKTrouverNombreCache.csproj :** contient la configuration du projet .NET.
- **README.md :** contient la présentation du projet et les instructions d'utilisation.

## 7. Prérequis

Pour exécuter cette application, il faut disposer de :

- Windows, Linux ou macOS.
- Visual Studio Code ou un autre éditeur compatible.
- Le SDK .NET correspondant à la version indiquée dans le fichier `.csproj`.
- Un terminal pour exécuter les commandes .NET.

Aucune bibliothèque externe supplémentaire n'est nécessaire.

## 8. Instructions pour lancer l'application

### Méthode 1 : Avec le terminal

1. Télécharger et décompresser le dossier du projet.
2. Ouvrir le dossier `FKTrouverNombreCache` dans Visual Studio Code.
3. Ouvrir le terminal intégré.
4. Exécuter la commande :

```bash
dotnet restore
```

5. Puis lancer l'application avec :

```bash
dotnet run
```

### Méthode 2 : Avec Visual Studio Code

1. Ouvrir le dossier du projet dans VS Code.
2. Ouvrir le fichier `Program.cs`.
3. Ouvrir le terminal intégré.
4. Exécuter `dotnet run`.

Le menu principal du jeu s'affichera dans le terminal.

## 9. Scénarios de test

Les tests suivants permettent de vérifier le fonctionnement du programme :

| Test | Action | Résultat attendu |
|---|---|---|
| 1 | Choisir F | Démarrage du mode facile |
| 2 | Entrer une lettre à la place d'un nombre | Message d'erreur |
| 3 | Entrer un nombre hors de l'intervalle | Message d'erreur |
| 4 | Choisir D | Démarrage du mode difficile |
| 5 | Entrer des bornes invalides | Message d'erreur |
| 6 | Trouver le nombre caché | Message de victoire et calcul de la note |
| 7 | Entrer Q pendant une partie | Retour au menu selon le mode |
| 8 | Entrer Q dans le menu principal | Fermeture du programme |

## 10. Conclusion

Ce travail m'a permis de mieux comprendre la programmation en C# et de mettre en pratique les notions étudiées en cours.

J'ai notamment travaillé sur la structuration d'un programme à l'aide de méthodes, la validation des données saisies par l'utilisateur, la gestion des conditions et des boucles, ainsi que l'utilisation des collections et de la génération aléatoire.

J'ai également accordé une attention particulière à la gestion des erreurs afin de rendre l'application plus simple à utiliser.

**Merci pour votre attention et pour la lecture de mon travail.**

Cordialement,  
**Fatou Kine THIOUB**