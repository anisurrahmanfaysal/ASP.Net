FROM ubuntu

ARG DEBIAN_FORNTEND=noninteractive
RUN apt update
RUN apt install apache2 -y

# docker run in this port
EXPOSE 80

# apacke run in foreground
CMD apachectl -D FOREGROUND