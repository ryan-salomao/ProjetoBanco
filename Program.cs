Conta c1 = new Conta(1);
Conta c2 = new Conta(2);

c1.Depositar(1000.0);
//c1.Sacar(200.0);
Console.WriteLine("\nSaldo conta 1: " + c1.Saldo);

c2.Depositar(200.0);
//c2.Sacar(150.0);
Console.WriteLine("Saldo conta 2: " + c2.Saldo);

Console.WriteLine("\nPós-transferência\n");

c1.Transferir(c2, 500.0);
//c1 transfere $500,00 para a conta 2

Console.WriteLine("Saldo conta 1: " + c1.Saldo);
Console.WriteLine("Saldo conta 2: " + c2.Saldo);