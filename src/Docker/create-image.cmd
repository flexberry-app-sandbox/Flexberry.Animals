docker build --no-cache -f SQL\Dockerfile.PostgreSql -t animals/postgre-sql ../SQL

docker build --no-cache -f Dockerfile -t animals/app ../..
