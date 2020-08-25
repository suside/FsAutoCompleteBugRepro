## Bug example repository for fsharp/FsAutoComplete

When you open a project with at least one subdirectory unreadable by the current user, FSAC will not work.

### Steps to reproduce
```
git clone https://github.com/suside/FsAutoCompleteBugRepro
cd FsAutoCompleteBugRepro
sudo chown root -R no_access_dir
sudo chmod 0600 -R no_access_dir
code ./
```
from now on FSAC will log only
```
[LSP] PositionHandler - Cached typecheck results not yet available for .../project1/Program.fs
```

### Expected behavior
Meaningful error on the output panel + ignoring unreadable directories.