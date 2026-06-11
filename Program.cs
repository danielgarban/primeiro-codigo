// Escreva a mensagem "Informe um numero:"
Console.Write("Informe um numero:");
// Cria a variavelQueSalvaUmNumero,
 // Leio que o usuario digitar
 // e transforma ovalor lido de texto para inteiro (int.parse)
int variavelQueSalvaUmNumero = int.Parse(Console.ReadLine()!);

// verifica se o valor de variavelQueSalvaUmNumero é par
if (variavelQueSalvaUmNumero % 2 == 0){
    Console.WriteLine($"Nuemro { variavelQueSalvaUmNumero} é par");
}else {
     Console.WriteLine($"Nuemro { variavelQueSalvaUmNumero} é impar");
}