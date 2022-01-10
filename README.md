# md2html

This is a CLI program that uses the [MarkDig][MARKDIG] and [ColorCode][COLORCODE] projects to convert a markdown file into HTML which doesn't need a css file. Note I cloned these projects roughly back in 2019, so the code bases are probably a bit different now. I did not provide the source here but instead provided the two DLL's in the resources directory.

- xoofx/Markdig: https://github.com/xoofx/markdig/
- ColorCode.Portable.1.0.3: https://colorcode.codeplex.com/ (link no longer works, Microsoft pulled the plug)

I think back when I cloned ColorCode from CodePlex, it was in a directory like `slater/ColorCode` and the author's name might be Bashir Souid.

## Usage

md2html infile.md outfile.html

## Install

Clone the project and either use the publish.bat(win) or publish.sh (mac/linux). Then navigate to the publish directory. For me on my mac, I linked the file to use/local/bin:

```sh
cd bin/Release/netcoreapp3.1/osx.10.12-x64/publish
M=$(pwd)/md2html
cd /usr/local/bin
ln -s $M md2html
```


[MARKDIG]: https://github.com/xoofx/markdig/
[COLORCODE]: https://colorcode.codeplex.com/
