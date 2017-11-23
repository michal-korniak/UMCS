using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityAndMediator
{
    public class ProjectMediator
    {
        public double Estimate { get; set; }
        private List<string> _developProgress;

        public ProjectMediator()
        {
            _developProgress = new List<string>();
        }

        public void AddProgress(string name, string positon, string phase, string note)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Autor: <{name}, {positon}>")
                .AppendLine($"Data: <{DateTime.Today}>")
                .AppendLine($"Tresc: <{phase}><{note}>")
                .AppendLine().AppendLine().AppendLine();
            _developProgress.Add(builder.ToString());
        }

        public void ShowDevelopProgress()
        {
            foreach (var progress in _developProgress)
            {
                Console.WriteLine(progress);
            }
        }
    }
}
