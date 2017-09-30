#Commands used with .Net core CLI

### Clone GitHub repo
```bash
git clone https://github.com/NileshGule/cSharpCollectionFundamentals.git cSharpCollectionFundamentals
```

### Create new solution `CollectionFundamentals` using dotnet commands
```bash
dotnet new sln --name CollectionFundamentals
```

### Create new project `Arrays` of the type console application
```bash
dotnet new console --name Arrays
```

### Add the newly created project to solution
```bash
dotnet sln add ./Arrays/Arrays.csproj
```