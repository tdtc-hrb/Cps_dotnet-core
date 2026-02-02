Windows Forms Guide
----

- [Creating a Database with Code First in EF Core](https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core-example.html)


## DB
When consist = -1, it is in the waiting state.    
When consist = 0, it is the initial state.    
is_obsoleted: obsolete flag    
pl_weight: Profit and loss weight

### lotnumstatuses
检斤站的车次状态:    
|Value|Name|
|-|-|
|-1|未编组|
|0| 新编组|
|1| 完成编辑|
|2| 无效编组|

## Model
[C#: what is the usage of virtual keyword in Entity Framework](https://social.msdn.microsoft.com/Forums/en-US/444cb716-59be-4b48-b4ef-e6a48fd252c6/c-what-is-the-usage-of-virtual-keyword-in-entity-framework?forum=adodotnetentityframework)
```
In the context of EF, marking a property as virtual allows EF to use lazy loading to load it.    
For lazy loading to work EF has to create a proxy object that overrides your virtual properties with an implementation that loads the referenced entity when it is first accessed.    
If you don't mark the property as virtual then lazy loading won't work with it.
```

### [Creating a Model](https://learn.microsoft.com/en-us/ef/core/modeling/)
- [table name](https://www.entityframeworktutorial.net/code-first/table-dataannotations-attribute-in-code-first.aspx)
- [column name](https://www.entityframeworktutorial.net/code-first/column-dataannotations-attribute-in-code-first.aspx)

### Data Type Mapping
- [Column data types](https://learn.microsoft.com/en-us/ef/core/modeling/entity-properties?tabs=data-annotations%2Cwithout-nrt#column-data-types)    
  numberic type of SQL
- [Entity Framework Data Type Mapping](https://www.devart.com/dotconnect/mysql/docs/datatypemapping.html)    
  numberic type of SQL

### [Composite Primary Key](https://hevodata.com/learn/mysql-composite-primary-key/)
```sql
CREATE TABLE Customers (
          order_id INT,
          product_id INT,
          amount INT,
          PRIMARY KEY (order_id, product_id)
     ) ;
```

## [DbContext](https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/)
- [Using Multiple Conditions with Count - LINQ](https://stackoverflow.com/a/26491275)
### [Querying and Finding Entities](https://learn.microsoft.com/en-us/ef/core/querying/)

### [Saving Data with Entity Framework core](https://learn.microsoft.com/en-us/ef/core/saving/)

- [Max](https://stackoverflow.com/a/7542129)
```
int maxAge = context.Persons.Max(p => p.Age);
```


## Windows Controls
- [How to close form](https://stackoverflow.com/questions/14381705/how-to-close-form)

### [StatusStrip](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.statusstrip)
- [Display a separator on the status strip in a winform](http://tech.cybernet.lu/?p=547)
![how to](http://tech.cybernet.lu/wp-content/uploads/2013/04/BlogStatusStrip.png)

### [TreeView](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.treeview)
- [Remove](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.treenodecollection.remove)
- [C# Loop through child nodes in a TreeView](https://www.experts-exchange.com/questions/28944585/C-Loop-through-child-nodes-in-a-TreeView.html)

#### [ContextMenuStrip](https://stackoverflow.com/questions/14208944/c-sharp-right-click-on-treeview-nodes)
```
private void treeview1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
{
    if (e.Button == MouseButtons.Right)
    {
        s = e.Node.Name;
        menuStrip1.Show();
    }
}
```

### [ListView](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.listview)
- [add data](https://stackoverflow.com/a/43841999)
- [How to add a string to a string array? There's no .Add function](https://stackoverflow.com/a/1440274)
- [get the value of a listview subitem](https://stackoverflow.com/a/15542188)
- [Select a row in listview](https://stackoverflow.com/a/12596740)
- [Delete Items from ListView in C sharp](https://stackoverflow.com/a/15572264)


## Other
- [stringbuilder to file](https://grabthiscode.com/csharp/c-stringbuilder-to-file)
- [json file](https://www.thecodebuzz.com/serialization-and-deserialization-using-system-text-json/)

### DateTime
- [convert date format](https://forum.uipath.com/t/converting-string-to-date-in-desired-format/320104/3)

### [NuGet - Online](https://learn.microsoft.com/en-us/nuget/consume-packages/configuring-nuget-behavior#example-nugetdefaultsconfig-and-application)
- name
```
nuget.org
```
- value
```
https://api.nuget.org/v3/index.json
```
- protocolVersion
> Not compatible with versions prior to VS2017

#### non-VS
NuGet.Config:
```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
  </packageSources>
</configuration>
```

### [NuGet - Offline](https://social.technet.microsoft.com/wiki/contents/articles/25127.nuget-offline-package.aspx)
- down [.nupkg](https://www.nuget.org/) file    
* [Microsoft.EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore)
* [MySql.EntityFrameworkCore](https://www.nuget.org/packages/MySql.EntityFrameworkCore#versions-body-tab)
* [Pomelo.EntityFrameworkCore.MySql](https://www.nuget.org/packages/Pomelo.EntityFrameworkCore.MySql)

- Set Package sourece    
Tools -> Options    
NuGet Package Manager -> Package Sources    
add new source:
```
Name: Microsoft Visual Studio Offline Packages
Source: C:\Program Files (x86)\Microsoft SDKs\NuGetPackages\
```

### [Error CS0579 Duplicate 'global::System.Runtime.Versioning.TargetFrameworkAttribute'](https://stackoverflow.com/a/63853501)
```
    <GenerateAssemblyInfo>false</GenerateAssemblyInfo>
    <GenerateTargetFrameworkAttribute>false</GenerateTargetFrameworkAttribute>
```

### ComboBox
- [Current index](https://stackoverflow.com/a/7341491s)

### System.Diagnostics.Process
- [Run Command Prompt Commands](https://stackoverflow.com/a/1469790)

### [ASCII](https://stackoverflow.com/a/14145356)
ASCII encoding replaces non-ascii with question marks, so we use UTF8 to see if multi-byte sequences are there

### [build project](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-build)
> This article applies to: .NET Core 3.1 SDK and later versions
```
cd Cps_dotnet-core
dotnet build
```
