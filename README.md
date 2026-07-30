# BadApple-JavascriptGame
A Bad apple game in javascript where you try to keep the cursor in the white spots

This game due to the usage of canvases, Requires to be launched on a local server, or it will give an "Insecure operation" error

In the releases folder has included a minimal http server so you can run the game

## Running the game
1. To start it, run "BasicHTTPServer.exe" (or run in the terminal `./BasicHTTPServer` on linux) it will open a command prompt that will run the server, and your browser in the webpage `http://localhost:8000/index.html`
   
   **OR You can also use any form of HTTP server of your preference if you have avalible any tool that supports it, such as python, Node JS, PHP , etc...**
  - in this case, Launch your preffered server under the folder `\BadAppleTheGameTheMovie\BadAppleJS` instead
2. if the browser doesn't opens automatically, open it manually, and go to the mentioned URL
3. You can either CTRL+C or close the command prompt once you closed the game on the webpage

## Building

1. Compile the HTTP server
### Windows
`dotnet publish BasicHTTPServer.sln -r win-x64 -p:PublishSingleFile=true --self-contained true -p:EnableCompressionInSingleFile=true -p:PublishTrimmed=true`

### Linux
`dotnet publish BasicHTTPServer.sln -r linux-x64 -p:PublishSingleFile=true --self-contained true -p:EnableCompressionInSingleFile=true -p:PublishTrimmed=true`

### Cross-platform
`dotnet publish BasicHTTPServer.sln`

2. Place the recieved binary or binaries in a folder
3. Place the BadAppleJS folder on the same level as your binary/ies file
4. **Unzip the files under /BadAppleJS/assets/bapple/** be sure to unzip them without preserving any file path so the files must be under the same folder as the zip files
5. if desired, delete the zip files
