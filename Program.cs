const string answer = "piggy";
var password = "";
var tries = 0;

do
{
    if (tries > 0)
    {
        Console.WriteLine("INCORRECT!");

        switch (tries)
        {
            case 1:
                Console.WriteLine("Are you reading my other message?");

                break;

            case 2:
                Console.WriteLine("Read the secret message at the other text file");

                break;

            case 3:
                Console.WriteLine("The secret password is at the text file");

                break;

            case 4:
                Console.WriteLine("Use Base 64 decryption to decrypt the secret text");

                break;

            case 5:
                Console.WriteLine("Search for codes to decrypt Base 64 and decrypt the secret text");

                break;

            default:
                Console.WriteLine("You can use Powershell script to decrypt the Base 64 text");
                Console.WriteLine("[System.Text.ASCIIEncoding]::ASCII.GetString([Convert]::FromBase64String(\"encrypted_message\"))");

                break;
        }

        Console.WriteLine();
    }

    Console.Write("Enter the password: ");

    password = Console.ReadLine();

    tries++;
}
while (password != answer);

Console.WriteLine("SECRET AREA HAS BEEN ENTERED");
Console.Write("Loading");

for (var i = 0; i < 10; i++)
{
    Console.Write('.');
    Thread.Sleep(100);
}

Console.WriteLine(" Done!");

Console.Write("Decrypting secret message");

for (var i = 0; i < 10; i++)
{
    Console.Write('.');
    Thread.Sleep(200);
}

Console.WriteLine(" Done!");

Console.WriteLine("SECRET MESSAGE ACQUIRED");
Console.WriteLine("=======================");
Console.WriteLine("The message is:");
Console.WriteLine("The rendezvous location is at 1437841239#6");
Console.WriteLine("Use your agent number to enter");

Console.ReadLine();
