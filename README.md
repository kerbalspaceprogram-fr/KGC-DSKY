Simulation AGC-DSKY pour KSP

Ce plugin/addon est en développement et n'est pas implémenté dans KSP pour le moment. 
Je prends le temps de découvrir le C# et le fonctionnement de l'AGC-DSKY en même temps.

Ce plugin a pour vocation de ressembler à l'AGC-DSKY, mais pas de l'émuler à 100%. C'est déjà assez compliqué comme ça :p (et surtout, certaines fonctions sont sans intérêt dans KSP)

Quelques spécifications pour une idée globals : 
-Mots de 16 bits
-8 * 256 mots de RAM (2kw)
-36 * 1024 mots de ROM (36kw)
12ms / cycle
environ 30  instructions AGC (YUL) + un langage interprété en interne.
-registres I/O : 2 * 4 mots

Comme vous pouvez le voir, c'est pas un truc de compétition, et pourtant, va falloir que ça vole :)

Changelog :
02/11/2013:
YUL : YUL fonctionne et devrait compiler le code AGC normalement. Le code interprété n'est pas encore géré.
YUL GUI : c'est moche, mais ça fait ce qu'on lui demande. Je le laisse en état pour l'instant, c'est pas ma priorité,
ça tient lieu de placeholder pour un futur debugger.

08/10/2013 :
YUL:
Résolutions des labels
Reconnaissance des OPCODEs
Changement de bank.
TODO : Implémentation des instructions de compilation

06/10/2013 : 
Accès mémoire et fichier mémoire : DONE (Bank class)
Manipulation de mots de 16 bits : DONE (sWord class)
Emulation d'horloge : TODO (placeholder CLOCK class)
AGC : TODO (bases are set, interpreter should work. OPCODES need to be coded)

Any suggestions welcome. The code is "documented" and may be understandable, but any question welcome too :)