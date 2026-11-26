double ValorSOL;
int parcelas;
double renda;

Console.Write("DIGITE O VALOR DO EMPRESTIMO SOLICITADO: ");
ValorSOL = Convert.ToDouble(Console.ReadLine());
Console.Write("DIGITE O VALOR DAS PARCELAS DO EMPRESTIMO SOLICITADO: ");
parcelas = Convert.ToInt32(Console.ReadLine());
Console.Write("DIGITE O VALOR DA RENDA MENSAL: ");
renda = Convert.ToDouble(Console.ReadLine());

var limite = ValorSOL / parcelas;
renda = (renda * 0.3);

if(renda < limite)
{
    Console.WriteLine("EMPRESTIMO NÃO-AUTORIZADO");
}
else
{
    Console.WriteLine("EMPRESTIMO AUTORIZADO");
}
