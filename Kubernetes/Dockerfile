FROM microsoft/dotnet:2.2-sdk

RUN git clone https://github.com/SebastianBienert/DOCKER_PROJECT.git
RUN ls
WORKDIR /DOCKER_PROJECT
COPY entrypoint.sh /DOCKER_PROJECT
RUN chmod +x entrypoint.sh
RUN dotnet restore "EducationalProgram/EducationalProgram.csproj"
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
CMD /bin/bash entrypoint.sh