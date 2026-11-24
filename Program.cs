

// Console.WriteLine($"Компьютер: {Environment.MachineName}");
// Console.WriteLine($"Пользователь: {Environment.UserName}");
// Console.WriteLine($"Дата и время: {DateTime.Now:dd.MM.yyyy HH:mm}");





// Шаг 1

// Console.WriteLine($"ОС: {Environment.OSVersion}");
// Console.WriteLine($"64-битная ОС: {Environment.Is64BitOperatingSystem}");




// Шаг 2

// Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");



// Шаг 3

Console.WriteLine($"PID процессора: {Environment.ProcessId}");
long memory = Environment.WorkingSet / 1024 / 1024;
Console.WriteLine($"Память процесса: {memory} МБ");
Console.ReadLine();