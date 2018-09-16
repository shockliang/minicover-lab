Package: MinCover
https://www.nuget.org/packages/MiniCover/

* install and setup in porject
```xml
<ItemGroup>
    <DotNetCliToolReference Include="MiniCover" Version="2.0.0-ci-VERSION" />
</ItemGroup>
```

* dotnet restore
* dotnet build

* Setup the minicover work dir path
```bash
dotnet minicover instrument --workdir ../ --assemblies test/**/bin/**/*.dll --sources src/**/*.cs
```
* Reset hits count in case minicover was run for this project
dotnet minicover reset

* Back to work dir root and run all test projects.
```bash
for project in test/**/*.csproj; do dotnet test --no-build $project; done
```

* Uninstrument assemblies, it's important if you're going to publish or deploy build outputs
```bash
dotnet minicover uninstrument --workdir ../
```

* Create html reports inside folder coverage-html
```bash
dotnet minicover htmlreport --workdir ../ --threshold 90
```

* Print console report
* This command returns failure if the coverage is lower than the threshold
```bash
dotnet minicover report --workdir ../ --threshold 90
```


