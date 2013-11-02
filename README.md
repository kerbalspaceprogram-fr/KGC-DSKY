Simulation AGC-DSKY pour KSP

Ce plugin/addon est en d�veloppement et n'est pas impl�ment� dans KSP pour le moment. 
Je prends le temps de d�couvrir le C# et le fonctionnement de l'AGC-DSKY en m�me temps.

Ce plugin a pour vocation de ressembler � l'AGC-DSKY, mais pas de l'�muler � 100%. C'est d�j� assez compliqu� comme �a :p (et surtout, certaines fonctions sont sans int�r�t dans KSP)

Quelques sp�cifications pour une id�e globals : 
-Mots de 16 bits
-8 * 256 mots de RAM (2kw)
-36 * 1024 mots de ROM (36kw)
12ms / cycle
environ 30  instructions AGC (YUL) + un langage interpr�t� en interne.
-registres I/O : 2 * 4 mots

Comme vous pouvez le voir, c'est pas un truc de comp�tition, et pourtant, va falloir que �a vole :)

Changelog :
02/11/2013:
YUL : YUL fonctionne et devrait compiler le code AGC normalement. Le code interpr�t� n'est pas encore g�r�.
YUL GUI : c'est moche, mais �a fait ce qu'on lui demande. Je le laisse en �tat pour l'instant, c'est pas ma priorit�,
�a tient lieu de placeholder pour un futur debugger.

08/10/2013 :
YUL:
R�solutions des labels
Reconnaissance des OPCODEs
Changement de bank.
TODO : Impl�mentation des instructions de compilation

06/10/2013 : 
Acc�s m�moire et fichier m�moire : DONE (Bank class)
Manipulation de mots de 16 bits : DONE (sWord class)
Emulation d'horloge : TODO (placeholder CLOCK class)
AGC : TODO (bases are set, interpreter should work. OPCODES need to be coded)

Any suggestions welcome. The code is "documented" and may be understandable, but any question welcome too :)