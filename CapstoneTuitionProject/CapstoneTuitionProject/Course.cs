namespace CapstoneTuitionProject
{
    class Course
    {
        private string courseCode;
        private string courseName;
        private int creditHours;
        private bool isOnline;

        public Course(string code, string name, int hrs, bool online = false)
        {
            courseCode = code;
            courseName = name;
            creditHours = hrs;
            isOnline = online;
        }

        public Course() { }

        public bool IsOnline { get { return isOnline; } set { isOnline = value; } }

        public string CourseCode
        {
            get { return courseCode;}

            set { courseCode = value; }
        }

        public string CourseName
        {
            get
            {
                return courseName;
            }

            set
            {
                courseName = value;
            }
        }

        public int CreditHours
        {
            get
            {
                return creditHours;
            }

            set
            {
                creditHours = value;
            }
        }

        public override string ToString()
        {
            return courseCode + " " + courseName;
        }
    }
}