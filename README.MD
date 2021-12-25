-Se debe tener instalado PSEXEC
-Compilar programa en release
-Colocar la carpeta release en la carpeta archivos de programa.
-Darle a la carpeta permisos todos TODO.
-Ejecutar el programa por remoto usando PsExec: para eso se debe ejecutar cmd en la máquina objetivo con los siguientes comandos:
psexec \\maquina -s cmd

-s es para iniciar el programa como System a fin de que no aparezca nuestro usuario.

-una vez con cmd ejecutado navegar a donde esta el programa usando cd y ejecutarlo usando start.
