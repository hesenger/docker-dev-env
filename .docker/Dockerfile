FROM mcr.microsoft.com/dotnet/sdk:6.0-bullseye-slim

RUN useradd -s /bin/bash -m vscode
RUN groupadd docker && usermod -aG docker vscode
RUN dotnet tool install csharpier -g

RUN apt-get update
RUN apt-get install -y openssh-server

USER vscode

ENTRYPOINT ["sleep", "infinity"]
