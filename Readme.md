# DinoGame

Un clone du jeu du dinosaure de Google Chrome, créé avec Unity. Ce projet est une version simple où le joueur peut uniquement sauter pour éviter des obstacles.

## Fonctionnalités principales

Mécanique de saut : Le joueur peut uniquement sauter pour éviter les obstacles.

Score dynamique : Un score augmente avec le temps.

Obstacles générés aléatoirement : Les obstacles apparaissent à des intervalles aléatoires et se déplacent vers la gauche.

Gameplay sans fin : Le jeu continue jusqu'à ce que le joueur percute un obstacle.

## Configuration du projet

#### Cloner le dépôt :

git clone <url-du-depot>

Ouvrir le projet dans Unity :

Lancez Unity Hub.

Cliquez sur « Open Project » et sélectionnez le dossier du projet cloné.

#### Configurer la scène :

Ajoutez les objets suivants :

Joueur : Un sprite représentant le dinosaure avec un Rigidbody2D et un BoxCollider2D.

Sol : Un GameObject rectangulaire avec un BoxCollider2D.

Obstacles : Des préfabs configurés avec un BoxCollider2D et un script pour se déplacer.

#### Configurer les tags :

Ajoutez le tag Ground à l'objet sol.

## Contrôles du jeu

Espace : Sauter.