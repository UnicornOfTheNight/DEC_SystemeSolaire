# 🪐 DEC Système Solaire

![Type](https://img.shields.io/badge/Type-Simulation%203D-blueviolet)
![Science](https://img.shields.io/badge/Science-Astronomie-orange)
![License](https://img.shields.io/badge/License-MIT-blue)

Une simulation interactive du système solaire réalisée dans le cadre du cursus **DEC**. Ce projet vise à modéliser les mouvements planétaires, les rotations et les échelles relatives de notre système stellaire.

## 🔭 Description

Ce projet permet de visualiser le soleil et les planètes en temps réel. L'objectif principal est de comprendre et d'appliquer les **mathématiques vectorielles** et les principes de **mécanique céleste** (orbites, rotation sur soi-même, vitesse de révolution) dans un environnement 3D.

> **Note :** Les échelles de distance et de taille ont été adaptées pour rendre la simulation visuellement agréable (sinon les planètes seraient invisibles à l'échelle réelle !).

## ✨ Fonctionnalités

* **Système complet** : Soleil, Mercure, Vénus, Terre (avec Lune), Mars, Jupiter, Saturne, Uranus, Neptune.
* **Mécanique orbitale** : Gestion des vitesses de révolution autour du soleil.
* **Rotation** : Rotation des planètes sur leur propre axe (cycle jour/nuit).
* **Caméra libre** : Possibilité de naviguer dans l'espace, de zoomer et de se focaliser sur une planète spécifique.
* **Textures & Matériaux** : Rendu visuel des surfaces planétaires.

## 🛠 Technologies Utilisées

* **Moteur** : Unity
* **Langage** : C#
* 
## 🎮 Commandes (Contrôles)

| Action | Clavier / Souris |
| :--- | :--- |
| **Se déplacer** | Flèches |
| **Orienter la caméra** | Clic Droit maintenu + Souris |
| **Zoomer / Dézoomer** | Molette de la souris |
| **Changer de vue** | Touches C |
| **Quitter** | Echap |

## 🚀 Installation & Lancement

1.  **Cloner le projet :**
    ```bash
    git clone [https://github.com/UnicornOfTheNight/DEC_SystemeSolaire.git](https://github.com/UnicornOfTheNight/DEC_SystemeSolaire.git)
    ```

2.  **Ouvrir le projet :**
    * Ajoutez le dossier dans **Unity Hub** et lancez l'éditeur.

3.  **Lancer la simulation :**
    * Ouvrez la scène principale (`MainScene` ou `SolarSystem`).
    * Appuyez sur **Play**.

## 🧠 Défis Techniques

* **Gestion de l'échelle** : Trouver un équilibre entre réalisme et lisibilité.
* **Hiérarchie des objets** : Gérer les parents/enfants (ex: La Lune est enfant de la Terre, qui est enfant du Soleil ou d'un pivot).
* **Géométrie** : Utilisation de `Sin` et `Cos` pour calculer les positions orbitales circulaires ou elliptiques.

## 👥 Auteur

* **UnicornOfTheNight** - *Développement & Intégration*

---
*Projet scolaire réalisé pour le DEC (Diplôme d'Études Collégiales).*
