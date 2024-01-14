using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;


public enum TaskPriority
{
    High,
    Medium,
    Low
}


namespace TaskManager
{
    public class ToDo
    {
        public string Name { get; set; }
        public TaskPriority Priority { get; set; }
        public List<string> Tags;
        public string Comment { get; set; }
        public string PathToAttachedFile { get; set; }



        public DateTime DeadLine { get; set; } = DateTime.MinValue;
        public Timer TimerToDo { get; set; } = new Timer(1);
        private int Milliseconds { get; set; } = 1;



        public ToDo()
        {
            Name = "";
            DeadLine = DateTime.MinValue;
            Priority = TaskPriority.Low;
            Tags = new List<string>();
            Comment = "";
            PathToAttachedFile = "";
            TimerToDo = new Timer();
        }

        public ToDo(string name, DateTime deadLine, TaskPriority priority, List<string> tags, string comment, string path)
        {
            Name = name;
            DeadLine = deadLine;
            Priority = priority;
            Tags = new List<string>(tags);
            Comment = comment;
            PathToAttachedFile = path;
        }

        public ToDo(string name, TaskPriority priority, List<string> tags, string comment, string path, int milliseconds)
        {
            Name = name;
            Priority = priority;
            Tags = new List<string>(tags);
            Comment = comment;
            PathToAttachedFile = path;

            Milliseconds = milliseconds;
            TimerToDo = new Timer(Milliseconds);
            TimerToDo.Start();
            TimerToDo.Elapsed += TimerMessage;
        }

        public void StartTimer()
        {
            TimerToDo.Start();
        }

        private void TimerMessage(object sender = null, ElapsedEventArgs e = null)
        {
            TimerToDo.Stop();
            System.Windows.Forms.MessageBox.Show($"Повідомлення: Час на виконання {Name} вийшов");
        }

        public override string ToString()
        {
            string pr = string.Empty;
            switch (Priority)
            {
                case TaskPriority.High:
                    pr = "Високий";
                    break;

                case TaskPriority.Medium:
                    pr = "Середній";
                    break;

                case TaskPriority.Low:
                    pr = "Низький";
                    break;
            }

            string result = $"|{Name} | {pr} | ";

            result += (DeadLine == DateTime.MinValue) ? ($"{(TimerToDo.Interval / 3600000):N3} годин на виконання | ") : ($"{DeadLine:dd-MM-yyyy} | ");

            if (!string.IsNullOrWhiteSpace(Comment)) result += Comment + " | ";
            if (!string.IsNullOrWhiteSpace(PathToAttachedFile)) result += Path.GetFileName(PathToAttachedFile) + " | ";
            if (Tags.Count > 0) result += string.Join(", ", Tags) + "|";

            return result;
        }

    }
}
