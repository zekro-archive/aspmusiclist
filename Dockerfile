FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build-env
WORKDIR /app


RUN curl -sL https://deb.nodesource.com/setup_12.x | bash - &&\
        apt-get install -y nodejs &&\
        npm install -g @angular/cli

COPY . .

RUN dotnet restore &&\
    dotnet build



EXPOSE 8080

CMD dotnet bin/Debug/netcoreapp2.1/musicList2.dll
