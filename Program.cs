using desafio_testes_unitarios_TDD_DIO;

Calculadora calculadora = new Calculadora();

int num1 = 5;
int num2 = 10;

Console.WriteLine($"{num1} + {num2} = {calculadora.Soma(num1, num2)}");