double Altura, Peso, imc;
Console.WriteLine("Cálculo do Índice de Massa Corporal (IMC)");
Console.Write("Altura (m)..: ");
Altura = Convert.ToDouble(Console.ReadLine());
Console.Write("Peso (kg)...: ");
Peso = Convert.ToDouble(Console.ReadLine());
imc = Peso / Math.Pow(Altura, 2);
Console.WriteLine($"\nIMC: {imc:N1} kg/m²");