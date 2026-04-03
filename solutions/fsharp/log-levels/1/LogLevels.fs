module LogLevels

let message (logLine: string): string = logLine.Replace("[INFO]: ", "").Replace("[WARNING]: ", "").Replace("[ERROR]: ", "").Trim()

let logLevel(logLine: string): string = 
    if logLine[0..1] = "[E" then "error"
    elif logLine[0..1] = "[W" then "warning"
    elif logLine[0..1] = "[I" then "info"
    else ""

let reformat(logLine: string): string = 
    let twoParts = logLine[1..].Split("]: ")
    let newString = twoParts[1].Trim() + " " + $"({twoParts[0].ToLower().Trim()})"
    newString
