// Log a new event
string logFile = "log.txt";
string timestamp = DateTime.Now.ToString("HH:mm:ss");

File.AppendAllText(logFile, $"[{timestamp}] Aplication started \n");

Console.Write("Event logged. \n");
// Read back every logged event
Console.WriteLine("Event history");
using StreamReader reader = new StreamReader(logFile); 
String Line;
while ((Line = reader.ReadLine()) != null) {
    Console.WriteLine(Line);
}
;
// Count the logged events
string[] allLines = File.ReadAllLines(logFile);
Console.WriteLine($"\n Total events logged{allLines.Length}");
