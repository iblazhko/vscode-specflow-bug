FROM microsoft/dotnet:2.2-sdk

WORKDIR /app

COPY ./ ./

EXPOSE 8073

CMD ["dotnet", "test", "Product.Library.Acceptance.Tests/Product.Library.Acceptance.Tests.csproj"]
