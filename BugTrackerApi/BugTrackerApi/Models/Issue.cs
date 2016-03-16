using System;

namespace BugTrackerApi.Models
{
    public class Issue
    {
        public string Title { get; private set; }

        public string Description { get; private set; }

        public int Id { get; private set; }

        public Issue()
        {
            Title = "";
            Description = "";
            Id = 0;
        }

        public Issue(string title, string description, int id)
        {
            if (String.IsNullOrWhiteSpace(title)) throw new ArgumentNullException(nameof(title));
            if (String.IsNullOrWhiteSpace(description)) throw new ArgumentNullException(nameof(description));

            Title = title;
            Description = description;
            Id = id;
        }
    }
}