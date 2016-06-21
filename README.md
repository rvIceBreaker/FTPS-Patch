# FTPS-Patch
FTPS patch for windows to allow proper passive mode uploading.

Utilizes (and includes a copy of, for archival purposes) [MOVEit Freely CLI](https://moveitsupport.ipswitch.com/SUPPORT/mifreely/mifreely.htm) and provides a small wrapper to replace the standard Windows ftp.exe

This was created to enable compatibility with existing applications and systems which utilized Windows' ftp.exe while allowing proper passive mode communication. To do this, **passive mode is forced via the wrapper application**, which eliminates the need to update your calling scripts or applications in order to use passive mode.

[Passive Mode FTP](http://stackoverflow.com/questions/1699145/what-is-the-difference-between-active-and-passive-ftp) is useful if you're working behind a secured environment. **Its also probably not the recommended way of transfering files, especially if you're trying to keep that data secure.**
