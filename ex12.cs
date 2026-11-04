string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Selecione um numero inteiro");

do
{
    readResult= Console.ReadLine();
    if (readResult != null){
        valueEntered = readResult;
    }
    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true){
        if (validNumber <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"Vc selecionou um numero errado, porfavor digite um numero entre 5 e 10");
        }
    }
    else
    {
        Console.WriteLine("vc digitou um numero errado, tente novamente");

    }
} while(validNumber == false);

Console.WriteLine("numero digitado corretamente");
