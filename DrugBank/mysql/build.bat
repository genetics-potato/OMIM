REM converts the mysql dataabase schema source code to visualbasic source code
reflector --reflects -o ./mysql/ /namespace "mysql" /split --language=visualbasic /sql ./drugbank.sql

REM copy ORM source code to project source code directory
RD /S /Q "../DrugBank/mysql/"
xcopy "./mysql/*.*" "../DrugBank/mysql" /s /h /d /y /e /f /i