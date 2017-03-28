REM converts the mysql dataabase schema source code to visualbasic source code
"Reflector" --reflects -o "./drugbank/" /namespace "mysql" /split --language=visualbasic /sql ./drugbank.sql
"Reflector" --reflects -o "./cosmic/" /namespace "mysql" /split --language=visualbasic /sql ./cosmic.sql

REM copy ORM source code to project source code directory
RD /S /Q "../DrugBank/mysql/"
RD /s /q "../Cosmic/mysql"
xcopy "./drugbank/*.*" "../DrugBank/mysql" /s /h /d /y /e /f /i
xcopy "./cosmic/*.*" "../Cosmic/mysql" /s /h /d /y /e /f /i