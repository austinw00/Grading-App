# Set variables
$sourceDir = "C:\Users\Austin Wagner\Desktop\GradingApplication"
$destinationDir = "C:\GradingApplication"
$mainExecutable = "GradingApplication.exe"
$iconFile = "C:\Users\Austin Wagner\Desktop\GradingApplication\grading_application_icon.ico"

# Create the destination folder
if (!(Test-Path $destinationDir)) {
    New-Item -ItemType Directory -Path $destinationDir
}

# Copy the application and data files
Copy-Item -Path "$sourceDir\*" -Destination $destinationDir -Recurse -Force

# Create a shortcut on the Desktop for all users
$publicDesktop = [Environment]::GetFolderPath("CommonDesktopDirectory")
$shortcut = (Join-Path $publicDesktop "GradingApplication.lnk")

# Create the shortcut
$shell = New-Object -ComObject ("WScript.Shell")
$sc = $shell.CreateShortcut($shortcut)
$sc.TargetPath = (Join-Path $destinationDir $mainExecutable)
$sc.IconLocation = $iconFile
$sc.Save()
