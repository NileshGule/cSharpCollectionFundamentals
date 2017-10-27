#Commands used with .Net core CLI

### Clone GitHub repo
```bash
git clone https://github.com/NileshGule/cSharpCollectionFundamentals.git cSharpCollectionFundamentals
```

### Create new solution `CollectionFundamentals` using dotnet commands
```bash
dotnet new sln --name CollectionFundamentals
```

### Create new project __`Arrays`__ of the type console application
```bash
dotnet new console --name Arrays
```

### Add the newly created project to solution
```bash
dotnet sln add ./Arrays/Arrays.csproj
```

### Run the Arrays project using solution
```bash
dotnet run CollectionFundamentals.sln --project Arrays
```

### Run the Arrays project using project by navigating to __Arrays__ directory
```bash
dotnet run Arrays
```

### Create new project __`Arrays`__ of the type console application
```bash
dotnet new console --name Collections
```

### Add the newly created project to solution
```bash
dotnet sln add ./Collections/Collections.csproj
```
### Run the Collections project using project by navigating to __Arrays__ directory
```bash
dotnet run Collections
```