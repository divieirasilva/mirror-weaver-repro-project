STEPS TO REPRODUCE ERROR

#1 - Build the Offline Scene (when this scene starts, it will connect automatically)

#2 - Open the Server Scene on Unity and just click Play

#3 - When the client connects on server you will see a "Called the wrong OnServerAddPlayer" error log on Unity.

STEPS TO ERROR DISAPPEAR

#1 - Open PlayerModule.cs and comment the lines 7 and 16

#2 - Build the Offline Scene (when this scene starts, it will connect automatically)

#3 - Open the Server Scene on Unity and just click Play

#4 - When the client connects on server you will see a "Called the correct OnServerAddPlayer" log on Unity.
