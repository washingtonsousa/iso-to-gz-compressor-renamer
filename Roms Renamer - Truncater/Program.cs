// See https://aka.ms/new-console-template for more information
string dir = @"O:\Games\Roms\ps2";

var files = Directory.GetFiles(dir);

foreach (var file in files)
{
    string newFile = file
       .Replace(".gz", ".gz")
    .Replace(" .gz", ".gz")
    .Replace(".gz", ".gz");

    try
    {
        System.IO.File.Move(file, newFile);

    }
    catch (Exception ex)
    {

    }

}
