namespace WebWIthoutReact.Logger
{
    public class FileLogger
    {
        private static FileLogger _logger= new FileLogger();

        public FileLogger()
        {

        }

        public static FileLogger CurrentLogger
        {
            get { return _logger; }
        }

        public void log(string message)
        {
            string path = @"D:\pratik.net\DAY BY DAY NOTES\day 13\IET_Dec_2025_Batch-master (9)\IET_Dec_2025_Batch-master\WebDemos\WebDemosDec25\data\log.txt";


            FileStream fs = null;
            if (File.Exists(path)) { 
            fs= new FileStream(path, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs= new FileStream(
                    path, FileMode.Create, FileAccess.Write);
            }
        
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine($"--Logged at {DateTime.Now.ToString()} - {message}");

            writer.Close();
            fs.Close(); 
        }

    }
}
