# FTPS-Patch
FTPS patch for windows to allow proper passive mode uploading.

Utilizes (and includes a copy of) [MOVEit Freely CLI](https://moveitsupport.ipswitch.com/SUPPORT/mifreely/mifreely.htm) and provides a small wrapper to replace the standard Windows ftp.exe

This was created to enable compatibility with existing applications and systems which utilized Windows' ftp.exe while allowing proper passive mode communication.

**Note: To truely maintain the backwards compatibility I required, passive mode is forced on. You don't have to change your calling code to use passive mode.**
