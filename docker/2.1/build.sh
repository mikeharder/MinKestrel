#!/usr/bin/env bash

docker build -t minkestrel -f `dirname $0`/Dockerfile `dirname $0`/../.. "$@"
