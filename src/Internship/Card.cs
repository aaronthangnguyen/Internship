using System;

namespace Internship
{
    public class Card
    {
        public Card(
            string companyName,
            string status,
            string deadline)
        {
            CompanyName = companyName;
            Status = status;
            Deadline = deadline;
        }

        public string CompanyName { get; set; }
        public string Status { get; set; }
        public string Deadline { get; set; }
    }
}