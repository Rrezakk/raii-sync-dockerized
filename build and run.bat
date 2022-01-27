docker build . -t raii-sync
docker run --name raii-sync-p 8081:80 -d raii-sync
pause