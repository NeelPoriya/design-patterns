namespace ConsoleApp.Design_Patterns.Composite
{
    class Main
    {
        public static void main()
        {
            File textFile = new File("README.txt", 200);
            File imageFile = new File("Image.jpg", 1000);
            File videoFile = new File("Video.mp4", 2000);

            Folder folder1 = new("Folder1");
            Folder folder2 = new("Folder2");

            folder1.AddItem(textFile);
            folder1.AddItem(folder2);
            folder2.AddItem(imageFile);
            folder2.AddItem(videoFile);

            folder1.PrintStructure();
            folder2.PrintStructure();

            int folder1Size = folder1.GetSize();
            Console.WriteLine($"Size of folder1: {folder1Size}");

            folder1.Delete();
        }
    }
}
