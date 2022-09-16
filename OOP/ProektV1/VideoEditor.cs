public class VideoEditor : Creator
{


    public VideoEditor(string name) : base(name)
    {

    }

    public override void Act()
    {
        if (CreativityLevel >= 70 && Energy >= 80)
        {
            this.BrainstormVideoIdeas();
            this.CreateScript();
            this.VideotapeScript();
            this.EditingVideo();
            this.RenderingVideo();
        }
        else
        {
            throw new Exception("Cannot create video. Out of ideas and/or tired.");
        }
    }

    private void BrainstormVideoIdeas()
    {
        CreativityLevel -= 5;
        Energy -= 5;

        Console.WriteLine("Brainstorming video ideas....");
    }
    private void CreateScript()
    {
        CreativityLevel -= 5;
        Energy -= 5;

        Console.WriteLine("Creating video script....");
    }
    private void VideotapeScript()
    {
        CreativityLevel--;
        Energy -= 10;

        Console.WriteLine("Videotaping myself executing the script....");
    }
    private void EditingVideo()
    {
        CreativityLevel -= 5;
        Energy -= 5;

        Console.WriteLine("Editing the video ....");
    }
    private void RenderingVideo()
    {
        CreativityLevel--;
        Energy--;

        Console.WriteLine("Rendering the video ....");
    }

    public override string ToString()
        => $"Hello I am Video editor.My name is {Name}.";

    public override void Create()
    {
        throw new NotImplementedException();
    }
}