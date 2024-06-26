/*
5- Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de 
resposta de uma pergunta. O usuário pode optar por continuar respondendo a pergunta ou parar de responder.
 Não utilize a instrução break

Qual a instrução para sair de um loop ?
 a.quit
 b.continue
 c.break
 d.exit
 Qual a opção correta ? (Tecle x para sair)
 */

var option = "";

while (option != "x" && option != "c") {
    Console.WriteLine("Qual a instrução para sair de um loop? " +
        "\na.quit" +
        "\nb.continue" +
        "\nc.break" +
        "\nd.exit" + "");
    Console.WriteLine("Qual a opção correta? (Tecle x para sair)");
    option = Console.ReadLine();
}


Console.WriteLine("Processamento finalizado");
Console.ReadKey();