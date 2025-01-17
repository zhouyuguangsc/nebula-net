## NebulaNet
[![NuGet version (NebulaNet)](https://img.shields.io/nuget/v/NebulaNet.svg?style=flat-square)](https://www.nuget.org/packages/NebulaNet/)
[![CI](https://github.com/shyboylpf/nebula-net/workflows/E2E/badge.svg)](https://github.com/shyboylpf/nebula-net/actions/workflows/ci.yml)
[![license](https://img.shields.io/badge/license-Apache%202.0-green.svg)](https://github.com/shyboylpf/nebula-net/blob/master-matt/LICENSES/Apache-2.0.txt)
[![issues](https://img.shields.io/github/issues/shyboylpf/nebula-net.svg)](https://github.com/shyboylpf/nebula-net/issues)

Nebula NET client.

## Install with .NET CLI

[https://www.nuget.org/packages/NebulaNet/](https://www.nuget.org/packages/NebulaNet/)
```shell
dotnet add package NebulaNet
```

## Quick Start

```csharp
using NebulaNet;
using System;
using System.Text;
using System.Threading.Tasks;
GraphClient graphClient = new GraphClient("127.0.0.1", 9669);
graphClient.Authenticate("root", "nebula");
Console.WriteLine(graphClient.sessionId);

StringBuilder sb = new StringBuilder();
sb.Append("CREATE SPACE IF NOT EXISTS test(vid_type=FIXED_STRING(30));");
sb.Append("USE test;");
sb.Append("CREATE TAG IF NOT EXISTS person(name string, age int);");
sb.Append("CREATE EDGE like (likeness double);");

var executionResponse = await graphClient.Execute(sb.ToString());

await Task.Delay(10000);

executionResponse = await graphClient.Execute("INSERT VERTEX person(name, age) VALUES \"Bob\":(\"Bob\", 10), \"Lily\":(\"Lily\", 9);");
await Task.Delay(5000);
executionResponse = await graphClient.Execute("INSERT EDGE like(likeness) VALUES \"Bob\"->\"Lily\":(80.0);");
await Task.Delay(5000);
executionResponse = await graphClient.Execute("FETCH PROP ON person \"Bob\" YIELD vertex as node;");
await Task.Delay(5000);
executionResponse = await graphClient.Execute("FETCH PROP ON like \"Bob\"->\"Lily\" YIELD edge as e;");
await Task.Delay(5000);
executionResponse = await graphClient.Execute("DROP SPACE test;");
await Task.Delay(5000);

await graphClient.SignOff();
```

## License

Nebula NET is under Apache2.0 license.
