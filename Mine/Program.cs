List<Figure> figures = [];

while (true)
{
  Console.WriteLine(
    @"Скажи бля цифру!
    1. Добавить слон в фигурный.
    2. Вывести весь."
  );

  string? input = Console.ReadLine();

  if (!int.TryParse(input, out int number))
    continue;

  if (number == 1)
  {
    Console.WriteLine("1 for rectangle 2 for triangle");

    input = Console.ReadLine();

    if (!int.TryParse(input, out number))
      continue;

    if (number == 1)
      figures.Add(new Rectangle());
    else if (number == 2)
      figures.Add(new Triangle());
  }
  else if (number == 2)
  {
    foreach (Figure figure in figures)
    {
      figure.Log();
    }
  }
}
