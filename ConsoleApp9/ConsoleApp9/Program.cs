// See https://aka.ms/new-console-template for more information
/*
class Tutorial
{
    protected int TutorialID;
    protected String TutorialName;

    public void SetTutorial(int pID, String pName)
    {
        TutorialID = pID;
        TutorialName = pName;
    }

    public String GetTutorialName()
    {
        return TutorialName;
    }
}


public class Tutorial
{
    public String TutorialName { get; set; }
    private int TutorialID;
    
}


class ATutorial: Tutorial
{
    public void RenameTutorial(String pNewName)
    {
        TutorialName= pNewName;
    }

    static void Main(String[] args)
    {
        ATutorial pTutor = new ATutorial();
        pTutor.RenameTutorial(".Net by abc");
        Console.WriteLine(pTutor.GetTutorialName());
        Console.ReadKey();
    }
}
*/

/*
class ProgramA
{
    protected String Name;

    public void SetProgramA(String pName)
    {
        Name = pName;
    }

    public String GetName()
    {
        return Name;
    }
}

class ProgramB: ProgramA
{
    public void NewName(String pNewName)
    {
        Name = pNewName;
    }

    static void Main(String[] args)
    {
        ProgramB pNewName = new ProgramB();
        pNewName.NewName("Hello defg");
        Console.WriteLine(pNewName.GetName());
        Console.ReadKey();
    }
}
*/


class ProgramA
{
    protected String Name;

    public void SetProgramA(String pName)
    {
        Name = pName;
    }

    public String GetName()
    {
        return Name;
    }
}

class ProgramB : ProgramA
{
    public void NewName(String pNewName)
    {
        Name = pNewName;
        //String myString = "My program code";
        Console.WriteLine("My program code");
    }

    
}

class ProgramC: ProgramB
{
    static void Main(String[] args)
    {
        ProgramC pNewName = new ProgramC();
        pNewName.NewName("defg");
        Console.WriteLine(pNewName.GetName());
        Console.ReadKey();
    }
}

