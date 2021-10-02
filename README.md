Installing Redis Cache in a Docker container

--> docker pull redis

For starting the container we will use the following command.

-->docker run --name local-redis -p 6379:6379 -d redis

Once the container starts, we can check it using the command

-->docker logs -f local-redis

This command will get us inside of the docker container for Redis. Once we are inside, we can just fire redis-cli, which will open the command-line interface. Finally, we can send a ping to the CLI, and if everything is working, we will get a PONG response, indicating that the Redis is running properly

-->docker exec -it local-redis /bin/bash

