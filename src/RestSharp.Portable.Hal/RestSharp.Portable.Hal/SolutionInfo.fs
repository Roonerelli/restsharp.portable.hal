﻿namespace System
open System.Reflection

[<assembly: AssemblyVersionAttribute("0.0.6")>]
[<assembly: AssemblyInformationalVersionAttribute("0.0.6-alpha")>]
[<assembly: AssemblyCompanyAttribute("Heartysoft Solutions Limited")>]
[<assembly: AssemblyCopyrightAttribute("Copyright © Heartysoft Solutions Limited 2015")>]
[<assembly: AssemblyMetadataAttribute("githash","master-7c8a90")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.6"
