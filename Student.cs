class Student{

     public static void  StudentGrade(){

        Console.WriteLine("Hello, Please Enter You Name: ");
        string name = Console.ReadLine() ?? "Unknown";
        Console.WriteLine("Please Enter the Number of Courses You have taken: ");
        int no_of_courses = Convert.ToInt32(Console.ReadLine());
        string[] subjects = new string[no_of_courses];
        Console.WriteLine("Enter the Subjects you took: ");
        for(int i = 0 ; i < no_of_courses ; i++){
            string subject = Console.ReadLine() ?? "Unknown";
            subjects[i] = subject;

        }

        Console.WriteLine("Enter the scores you got for each subject: ");
        int[] scores = new int[no_of_courses];
        for(int k = 0 ; k < no_of_courses ; k++){

            int score = Convert.ToInt32(Console.ReadLine());

            if (score < 0 || score >    100){

                throw new ArgumentException("Grades should be between 0-100");
            }

            scores[k] = score;
        }

        Console.WriteLine($"Hey {name}");
        Console.WriteLine("Below you can find the subjects and your scores");
        // Console.WriteLine( subjects.Length);
        // Console.WriteLine(scores.Length);

        for(int k = 0 ; k < no_of_courses; k ++){

            Console.WriteLine($"You have Scored {scores[k]} in {subjects[k]}");
        }

        double average = Average(scores);
        Console.WriteLine($"You average is {average}");


        //A function that takes in an array and returns the average.
        double Average(int[] grades){

            return (double)grades.Sum()/ grades.Length;
        }
    }

}