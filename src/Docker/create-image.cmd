docker build --no-cache -f SQL\Dockerfile.PostgreSql -t hotel/postgre-sql ../SQL

docker build --no-cache -f Dockerfile -t hotel/app ../..
