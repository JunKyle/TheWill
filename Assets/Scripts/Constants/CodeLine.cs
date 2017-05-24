﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CodeLine
{
    GeoffroyD1000, //Première fois qu'on parle à Geoffroy - Jour 1 - Premier choix
    GeoffroyD1001, // Second Choix
    GeoffroyD1002, // Troisième Choix
    GeoffroyD1003, // Troisième Choix - Contrat+
	GeoffroyD2001, // Avoir son contrat
	GeoffroyD2002,
	GeoffroyD2003, //Suite quête après contrat


    AbigailD1000,//Première fois qu'on parle à Aby - Jour 1
    AbigailD1001,// Intro Dialogue
    AbigailD1002,// idem - Choix 1 et 2
    AbigailD1003,// idem - Choix 3
    AbigailD1004,// idem - Choix 4


    HippoD1000,//Première fois qu'on parle à Hippo - Jour 1
    HippoD1001,//
    HippoD1002,//



    ErnestD1000,//Première fois qu'on parle à Ernest - Jour 1
    ErnestD1001,//Choix 1
    ErnestD1002,//Choix 2
    ErnestD1003,//Choix 3
    ErnestD1004,//Dial supp "Abi?"
	ErnestD2001,//Premier Dialogue J2
	ErnestD2002,//Premier echec à l'ouverture du Phone
	ErnestD2003,//

    OphelieD1000,//Première fois qu'on parle à Ernest - Jour 1
    OphelieD1001,//Choix 1
    OphelieD1002,//Choix 2
    OphelieD1003,//Inutilisé
    OphelieD2000,//Parler de la piste -> Débloquer Dialogue Hippo
	OphelieD2001,//Journal partie Abi lue
	OphelieD2002,//
	
	
    LeontineD1000,//Première fois qu'on parle à Leontine - Jour 1
    LeontineD1001,//
    LeontineD1002,//
    LeontineD1003,//
    LeontineD1004,//
    LeontineD1005,//
    LeontineD1006,//
	
	KimD2001,//Première entrée cuisine
	
	ObjetJournalC0001,// Si Journal Chambre de Celeste a ete vu
	
	HippOpheD2000,//Enigme en cours
	HippOpheD2001,//Enigme Succes
	HippOpheD2002,//Enigme Echec
	
}
