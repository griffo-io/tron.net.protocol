[![Build status](https://ci.appveyor.com/api/projects/status/eajbppflhmoeu3wk?svg=true)](https://ci.appveyor.com/project/dariogriffo/tron-net-protocol)
[![NuGet](https://img.shields.io/nuget/v/Tron.Net.Protocol.svg?style=flat)](https://www.nuget.org/packages/Tron.Net.Protocol/) 
[![GitHub license](https://img.shields.io/github/license/griffo-io/tron.net.protocol.svg)](https://github.com/griffo-io/tron.net.protocol/blob/master/src/LICENSE)


# tron.net.protocol

[![N|Solid](https://avatars2.githubusercontent.com/u/39886363?s=200&v=4)](https://github.com/griffo-io/tron.net.protocol)

Tron.Net is an UNOFFICIAL port in .NET standard of the [Tron protocol](https://github.com/tronprotocol/)

###### This library is still in experimental mode, use it with discretion, suggestions and PR are welcome.

## Downloads ##

The latest stable release of the Tron.Net.Protocol [available on NuGet](https://www.nuget.org/packages/Tron.Net.Protocol)


# How to build it

  - Checkout the code
  - Checkout the submodules tronprotocol googleapis and protobuf
  - Add to the proto files in the tronprocotol folder the following line `option csharp_namespace = "Tron.Net.Protocol";` under the line `option go_package = "github.com/tronprotocol/grpc-gateway/api";`
  - Check where you have your nuget packages downloaded and set an Environment Variable named `NuGetPackageRoot` with that (in my case I have my nuget local configured to E:\Nuget)
  - Edit the .csproj file and remove the `:: ` from the `Exec Command=`
  - Build the solution
  
  
Logo Provided by [Vecteezy](https://vecteezy.com)
  