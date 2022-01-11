# md2html

This is a CLI program that uses the [MarkDig][MARKDIG] and [ColorCode][COLORCODE] projects to convert a markdown file into HTML which doesn't need a css file. Note I cloned these projects roughly back in 2019, so the code bases are probably a bit different now. I did not provide the source here but instead provided the two DLL's in the resources directory.

- xoofx/Markdig: https://github.com/xoofx/markdig/
- ColorCode.Portable.1.0.3: https://colorcode.codeplex.com/ (link no longer works, Microsoft pulled the plug)

I think back when I cloned ColorCode from CodePlex, it was in a directory like `slater/ColorCode` and the author's name might be Bashir Souid.

## .NET Core

This program is built with .NET Core. If not already installed, here's how to install it:

https://docs.microsoft.com/en-us/dotnet/core/install/linux

## Usage

md2html infile.md outfile.html

**Note: the outfile will be overwritten without warning.**

## Install

Clone the project and either use the publish.bat(win) or publish.sh (mac/linux) to build and publish the project. Then navigate to the publish directory. On my Mac, the build is in `bin/Release/netcoreapp3.1/osx.10.12-x64/publish` and on my windows box it is in `bin\Release\netcoreapp3.1\win10-x64\publish\`

For me on my mac, I also linked the application file to usr/local/bin:

```sh
$ cd bin/Release/netcoreapp3.1/osx.10.12-x64/publish
$ M=$(pwd)/md2html
$ cd /usr/local/bin
$ ln -s $M md2html
```

---

### Sample install on my Raspberry Pi

Get the files

```sh
$ cd /tmp
$ git clone https://github.com/sflanders95/md2html.git
$ cd md2html
```

Modify publish.sh and comment out the MacOS line and uncomment the linux line. For linux, set your runtime to one of linux-x86, linux-arm, or linux-arm64. For my rasberry pi my publish.sh file command was:

```sh
dotnet publish --configuration Release --framework netcoreapp3.1 --runtime linux-arm --self-contained true md2html.csproj
```

Run the publisher:

```sh
$ sh publish.sh
```

The publish directory will vary based on the chipset you chose above. Put the files wherever you want them to live, I chose /opt

```s
$ mkdir /opt/md2html
$ cd bin/Release/netcoreapp3.1/linux-arm/publish
$ sudo mv * /opt/md2html
```

Then I made the program global:

```sh
$ cd /usr/local/bin
$ sudo ln -s /opt/md2html/md2html md2html
```

Check that it works:

```sh
$ cd
$ md2html
Usage:
  md2html [markdown file] [html file]
```

Clean up the /tmp dir:

```sh
$ rm -fr /tmp/md2html
```




[MARKDIG]: https://github.com/xoofx/markdig/
[COLORCODE]: https://colorcode.codeplex.com/
