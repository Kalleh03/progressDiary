

// so this is a follow along project to calculate grades of students. 
// It's a big step up from previous projects but it turns out it's kinda fun. 


// currentStudent
// studentNames
/*
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
*/
// currentStudentLetterGrade
// studentScoress

//At first we need to declare examAssignments, and set it to 5.  

int examAssignments = 5;

// After that we need the string of names of the students. 
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// Next we need int arrays of every student score.


int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// Also a int for studentScoress.
int[] studentScores = new int[0]; 


// a string for currentStudentLetterGrade = "".
string currentStudentLetterGrade = "";


// Here we need to clear the console and format our list of student, grade, letter, Letter grade . 
Console.Clear();
Console.WriteLine("Student\t\tGrade\tLetter\tLetter Grade");


// foreach list of currentStudent name in studentNames with a new string currentStudent = name;
// if elif list of students in array with string name to couple studentScores with namescore. 
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;     


    // save sumAssignmentScores
    int sumAssignmentScores = 0;


    // save currentStudentGrade
    decimal currentStudentGrade = 0;

    // save gradedAssignments
    int gradedAssignments = 0;

    // foreach statement score in studentScores.
    // inside we need gradedAssignments to +=1 with a if statement. 
    // else statement is sumAssignementScores += score / 10;

    foreach (int score in studentScores)
    {
        gradedAssignments +=1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;

        else
            sumAssignmentScores += score / 10;    
    }

    // Here we need to calculate the currentStudentGrade 
    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    // If statement starting at the top going lower. 
    // 97, 93, 90, 87, 83, 80, 77, 73, 70, 67, 63, 60,  F.

    if  (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A"; 

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";     

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63);

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else 
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
    
}   

// Result output with a Readline at the bottom to make the console stop. 

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
        

        

    
