# Multiplicación Rusa

##### El método de multiplicación rusa consiste en multiplicar sucesivamente por 2 el multiplicando y dividir por 2 el multiplicador hasta que el multiplicador tome el valor 1.
##### Luego, se suman todos los multiplicandos correspondientes a los multiplicadores impares.
##### Dicha suma es el producto de los dos números. La siguiente tabla muestra el cálculo realizado para multiplicar 37 por 12, cuyo resultado final es 12 + 48 + 384 = 444.

```csharp
    int multiplicador, multiplicando, a, b, c = 0;

    Console.Write("Ingrese el multiplicador: ");
    multiplicador = int.Parse(Console.ReadLine());

    Console.Write("Ingrese el multiplicando: ");
    multiplicando = int.Parse(Console.ReadLine());

    a = multiplicador;
    b = multiplicando;

    while(a != 0)
    {
        if(a % 2 != 0)
            c = c + b;

        a = a / 2;
        b = b * 2;    
    }
    
    Console.WriteLine($"Resultado: {c}");
    Console.ReadKey();
```