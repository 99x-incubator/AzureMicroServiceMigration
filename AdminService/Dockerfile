FROM microsoft/aspnetcore:2.0
ARG source
WORKDIR /app
EXPOSE 90
COPY ${source:-obj/Docker/publish} .
ENTRYPOINT ["dotnet", "AdminService.dll"]
