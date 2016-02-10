csc *.cs
FOR %%f in ("*.in.txt") DO (
	SETLOCAL EnableDelayedExpansion
    SET "file=%%f"
    doubleDowns.exe < "%%f" > "!file:.in.txt=.out.txt!"
)
del *.exe
