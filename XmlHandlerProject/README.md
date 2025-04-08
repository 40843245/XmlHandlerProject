# Xml Handler
## prequisite
Ensure that your environments satisfies these system requirements.

Also, ensure these dependencies (or packages) are installed.
### system requirements
1. Windows 10 or 11.
2. .NET Framework 4.6.2 to 4.8.1.

### used dependencies
1. current latest version of [`System.IO.Packaging` (Microsoft Developed)](https://www.nuget.org/packages/System.IO.Packaging/10.0.0-preview.2.25163.2)

## applies to
1. Any kinds of architecture (e.g. from ConsoleApp, ASP.NET.core MVC, Window Forms App).

## intro
There are these main functionalities:

1. Get XML content with given one of these arguments passed.


| option id | parameter name | parameter type | description |
| -- | --------- | ------------- | --------------- |
| option 1 | `fileName` | `string` | file that will be read for. It will get the package of the file. See following examples for more fully understands |
| option 1 | `relativeUri` | `System.Uri` | the relative uri of fileName. See following examples for more fully understands |
| option 2 | `package` | `System.IO.Packaging.Package` | package that will be read for. See following examples for more fully understands |
| option 2 | `relativeUri` | `System.Uri` | the relative uri of the package. See following examples for more fully understands |
| option 3 | `packagePart` | `System.IO.Packaging.PackagePart` | package part that be read for. See following examples for more fully understands |

2. Get Pakcage (an instance with `System.IO.Packaging.Package` class)  with given one of these arguments passed.

| option id | parameter name | parameter type | description |
| -- | --------- | ------------- | --------------- |
| option 1 | `fileName` | `string` | Get Pakcage of the file through opening the stream (`FileStream` instance). See following examples for more fully understands |
| option 2 | `stream` | `Stream` | Get Pakcage of the stream (`Stream` instance). See following examples for more fully understands |


## API 
### API implementation
With `System.IO.Packaging`.

### GetXmlContent
#### intro
Get XML content of specific packagePart (an `System.IO.Packaging.PackagePart` instance).

#### overloads (by defining the extension method)

1. 

```
public static string GetXmlContent(
            this string fileName,
            Uri relativeUri
        )
```

which defined in `XmlHandlerProject.Extensions.FileExtensions` static class.

2.

```
public static string GetXmlContent(
            this Package package,
            Uri relativeUri
)
```

which defined in `XmlHandlerProject.Extensions.PackageExtensions`  static class..

3. 

```
public static string GetXmlContent(
            this PackagePart packagePart
        )
```

which defined in `XmlHandlerProject.Extensions.PackagePartExtensions`  static class..

### GetPackage
#### intro
Get package (`System.IO.Packaging.Package` instance).

#### overloads (by defining the extension method)

1.

```
public static Package GetPackage(
   this Stream stream
)
```

which defined in `XmlHandlerProject.Extensions.PackagePartExtensions` static class..

2.

```
public static Package GetPackage(
   this string fileName
)
```

which defined in `XmlHandlerProject.Extensions.PackagePartExtensions` static class..