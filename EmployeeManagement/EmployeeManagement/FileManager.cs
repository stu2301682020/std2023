namespace EmployeeManagement
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;

    public class FileManager
    {
        private static readonly string fileName = "employeesData.json";

        private static readonly string filePath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

        private static readonly JsonSerializerOptions options = new()
        {
            WriteIndented = true
        };
        public static List<Employee> LoadEmployees()
        {
            try
            {
                string json = File.ReadAllText(filePath);
                if (!string.IsNullOrEmpty(json))
                {
                    return JsonSerializer.Deserialize<List<Employee>>(json) ?? new List<Employee>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading employees from file: {ex.Message}");
            }

            return new List<Employee>();
        }

        public static void SaveEmployees(List<Employee> employees)
        {
            try
            {
                string json = JsonSerializer.Serialize(employees, options);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving employees to file: {ex.Message}");
            }
        }
    }
}