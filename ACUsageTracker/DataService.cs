using System.Text.Json;

namespace ACUsageTracker
{
    public static class DataService
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sessions.json");

        public static void SaveSessions(List<SessionRecord> sessions)
        {
            try
            {
                string json = JsonSerializer.Serialize(sessions, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}");
            }
        }

        public static List<SessionRecord> LoadSessions()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    return JsonSerializer.Deserialize<List<SessionRecord>>(json) ?? new List<SessionRecord>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
            return new List<SessionRecord>();
        }
    }
}
