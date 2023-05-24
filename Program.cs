static int result(string[]sentences) 
{
    var max = 0;
    
    foreach(var sentence in sentences)
    {
        string [] words = sentence.Split(" ");
        int count = words.Length;

        if(count > max)
        {
            max = count;
        }
    }
    return max;
}

string[] sentences = {
            "Mauris ultricies sed sapien eget malesuada. Suspendisse et aliquet odio, id ultrices erat. Praesent vehicula erat nulla. Aliquam a lorem urna. Donec.",
            "Duis at tellus et ex bibendum pellentesque sed in nibh. Sed aliquet, diam id mollis facilisis, massa metus accumsan elit, at mattis magna.",
            "Sed non nibh quam. Pellentesque eget ultrices diam. Aliquam diam justo, consectetur ac dui lobortis, vestibulum bibendum lorem. Sed porta pulvinar."
        };

int maxWordCount = result(sentences);
Console.WriteLine(maxWordCount);
