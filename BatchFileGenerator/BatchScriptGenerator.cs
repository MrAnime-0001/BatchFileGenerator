using System;

namespace BatchFileGenerator
{
    public static class BatchScriptGenerator
    {
        public static string GenerateDeleteFileBatch(string filePath)
        {
            return $@"@echo off

:: WARNING: This command will DELETE the specified file.
:: File Path: {filePath}

del /q ""{filePath}""

echo File deletion command executed.
pause";
        }

        public static string GenerateDeleteFilesInFolderBatch(string folderPath)
        {
            return $@"@echo off

:: WARNING: This command will DELETE ALL FILES in the specified folder.
:: Folder Path: {folderPath}

del /q ""{folderPath}\*.*""

echo File deletion command executed.
pause";
        }

        public static string GenerateDeleteFolderTreeBatch(string folderPath)
        {
            return $@"@echo off

:: WARNING: This command will DELETE THE FOLDER AND ALL ITS CONTENTS (files and subfolders).
:: Folder Path: {folderPath}

rmdir /s /q ""{folderPath}""

echo Folder deletion command executed.
pause";
        }

        public static string GeneratePrioritySetterBatch(string processName, string priorityClass)
        {
            string powershellCommand = $@"powershell -Command ""& {{Get-Process '{processName}' | ForEach-Object {{ $_.PriorityClass = '{priorityClass}' }}}}""";

            return $@"@echo off

:: IMPORTANT: Running this command requires the batch file itself to be run as Administrator
:: to successfully change process priority.

set ""PROCESS_NAME={processName}""
set ""PRIORITY={priorityClass}""

echo Attempting to set priority for %PROCESS_NAME% to %PRIORITY%...
{powershellCommand}

echo Priority setting command executed.
pause";
        }

        public static string GenerateRoboCopyBatch(string sourcePath, string destinationPath, string fileMask)
        {
            return $@"@echo off

:: Source: {sourcePath}
:: Destination: {destinationPath}
:: File/Mask: {fileMask}

robocopy ""{sourcePath}"" ""{destinationPath}"" ""{fileMask}"" /E /Z /R:3 /W:5 /NDL /NJH /NJS

echo RoboCopy operation completed or attempted.
pause";
        }

        public static string GenerateVersionControlBatch(string sourcePath, string destinationPath)
        {
            return $@"@echo off
setlocal

:: Set the source and destination directories
set ""source_folder={sourcePath}""
set ""destination_folder={destinationPath}""

:: Set the optional base name for the copied folder
:: Leave empty to use default naming with ""v1"", ""v2"", etc.
set ""SetName=Copy""

:: Initialize the copy counter
set ""count=1""

:: Check for existing copies and find the next available number
:check_existing
if defined SetName (
    set ""folder_name=%SetName% v%count%""
) else (
    set ""folder_name=v%count%""
)

if exist ""%destination_folder%\%folder_name%"" (
    set /a count+=1
    goto :check_existing
)

:: Copy the folder and rename it with the incremented count
xcopy ""%source_folder%"" ""%destination_folder%\%folder_name%"" /E /I

echo Folder copied to ""%destination_folder%\%folder_name%""

endlocal
pause";
        }

        public static string GenerateCopyToClipboardBatch(string textToCopy)
        {
            return @$"@echo off


echo|set /p=""{textToCopy}"" | clip";
        }
    }
}
