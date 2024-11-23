# Child-control-app

This system comprises two components: a **server application** (administrator) and a **client application** (child device). Together, they form a robust **Process Management System** for monitoring, managing, and controlling running processes on remote machines. The server acts as a control center, while the client reports its activity and executes commands from the server.

---

## **Overview of Components**

### 1. **Server Application** (`Exam_act_control_0.1`)
The server application provides a graphical interface for monitoring and controlling connected clients. It allows administrators to:
- View active processes on connected clients.
- Terminate processes by their PID.
- Execute files remotely on the client machine.
- Log all activities for audit purposes.

### 2. **Client Application** (`TcpConsoleApp`)
The client application runs on the remote machine (child device) and:
- Reports all running processes to the server periodically.
- Listens for commands from the server to terminate processes or execute files.
- Executes commands securely while logging its own activity.

---

## **Detailed Description of the Client Application**

The client application is a **console-based program** built in C#. It connects to the server over TCP and communicates using a simple text-based protocol. It runs two concurrent threads: one for sending process information and another for listening to server commands.

### **Key Features**

1. **Process Reporting**:
   - Periodically sends a list of running processes, including their IDs and names, to the server.
   - Helps the server maintain an up-to-date view of the client's system.

2. **Command Execution**:
   - Executes server commands such as:
     - Terminating a process (`KillPID` command).
     - Opening a file specified by its path.

3. **Robust Communication**:
   - Maintains a persistent connection with the server.
   - Handles errors gracefully, ensuring reliability during unexpected disconnections.

4. **Lightweight and Efficient**:
   - Uses minimal system resources.
   - Sends updates every 500 milliseconds for near-real-time monitoring.

---

## **How It Works**

### **Client Workflow**
1. **Connection**:
   - The client establishes a TCP connection to the server at a predefined IP address and port.
   - A `NetworkStream` is used for bi-directional communication.

2. **Process Reporting**:
   - The client collects a list of all running processes using `System.Diagnostics.Process.GetProcesses()`.
   - Sends this data to the server in the format: `PID:ProcessName`.

3. **Command Listening**:
   - The client listens for commands from the server, such as:
     - `"KillPID:<PID>"` – Terminates the process with the specified PID.
     - `"C:\path\to\file.exe"` – Opens the specified file using `System.Diagnostics.Process.Start()`.

4. **Error Handling**:
   - Handles exceptions during process reporting or command execution.
   - Logs all errors to the console for debugging.

---

### **Server Workflow**
The server application receives process data from the client, displays it in a user-friendly GUI, and allows administrators to:
1. Search and filter the process list.
2. Issue commands to terminate processes or execute files on the client machine.
3. Log all activities in a file for traceability.

---

## **Technical Highlights**

### **Client Application Code Breakdown**
1. **Connection Setup**:
   ```csharp
   ConnectToServer("127.0.0.1", 20042);
   ```
   - Establishes a TCP connection with the server.

2. **Process Reporting**:
   ```csharp
   static List<string> GetRunningProcesses()
   {
       List<string> processes = new List<string>();
       foreach (var process in System.Diagnostics.Process.GetProcesses())
       {
           processes.Add($"{process.Id}:{process.ProcessName}");
       }
       return processes;
   }
   ```
   - Retrieves all running processes with their PIDs and names.

3. **Command Handling**:
   ```csharp
   if (message.StartsWith("KillPID:"))
   {
       int.TryParse(message.Substring(8), out int killPid);
       KillProcess(killPid);
   }
   ```
   - Parses and executes server commands for process termination.

4. **File Execution**:
   ```csharp
   System.Diagnostics.Process.Start(message);
   ```
   - Opens a file path received from the server.

---

### **Server Application Code Breakdown**
The server collects data and sends commands using:
1. **TCP Listener**:
   ```csharp
   listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 20042);
   listener.Start();
   ```
   - Listens for incoming client connections.

2. **Logging**:
   ```csharp
   string logMessage = $"{DateTime.Now}: {message}";
   using (StreamWriter sw = new StreamWriter(logFilePath, true))
   {
       sw.WriteLine(logMessage);
   }
   ```
   - Logs all events, including client connections, commands, and errors.

3. **Command Execution**:
   ```csharp
   foreach (var client in clients)
   {
       StreamWriter writer = new StreamWriter(client.GetStream());
       writer.WriteLine($"KillPID:{pid}");
       writer.Flush();
   }
   ```
   - Sends commands like `KillPID` to all connected clients.

---

## **How to Run**

### **Client Application**
1. Open the client project in Visual Studio.
2. Run the application.
3. Ensure the server application is running and reachable at `127.0.0.1:20042`.

### **Server Application**
1. Open the server project in Visual Studio.
2. Run the application.
3. Monitor connected clients and issue commands through the GUI.

---

## **Future Enhancements**
- **Encryption**: Add secure encryption for TCP communication to prevent unauthorized access.
- **User Authentication**: Implement user roles for more controlled access.
- **Cross-Platform Support**: Extend client compatibility to Linux and macOS.
- **GUI Client**: Provide a graphical client interface for better usability.

---

## **Conclusion**

The **Process Management System** provides an intuitive solution for administrators to manage remote systems effectively. With features like real-time monitoring, process control, and robust logging, it is a powerful tool for IT management scenarios.
