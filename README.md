# BicepTech

Ce projet utilise le langage Bicep pour définir et déployer une infrastructure Azure. L'objectif est de créer les ressources nécessaires pour prendre en charge une application Web dans le cloud.

## Configuration

### Paramètres

- `location`: Emplacement géographique pour le groupe de ressources.
- `storageNamePrefix`: Préfixe utilisé pour le nom du compte de stockage.
- `acr_name`: Nom du registre de conteneurs.
- `asb_name`: Nom de l'espace de noms Service Bus.
- `app_name`: Nom de l'application Web.

## Structure du Projet

- `main.bicep`: Fichier principal contenant la définition de l'infrastructure.
- `README.md`: Ce fichier, fournissant des informations sur le projet.
- `scripts/`: Répertoire potentiel pour les scripts d'automatisation ou de déploiement supplémentaires.

## Déploiement

### Prérequis

- [Bicep CLI](https://github.com/Azure/bicep/blob/main/docs/installing.md)
- Compte Azure avec les autorisations nécessaires pour déployer des ressources.

### Déployer l'infrastructure

```bash
bicep build main.bicep
az deployment group create --resource-group <Nom-du-Groupe-de-Ressources> --template-file ./main.json
