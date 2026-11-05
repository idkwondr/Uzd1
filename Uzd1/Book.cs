public class Book
{
	// Paskaidrojums: IsBorrowed ir ar private set, jo dati par grâmatas stâvokli ir Book klases atbildîba.
	// Tikai Book metodes (Borrow un Return) var mainît ðo stâvokli, nevis ârçjais kods.
	// Book un BookPrinter ir atseviðías klases, ievçrojot Single Responsibility Principle:
	// Book pârvaldo grâmatas datus un stâvokli, bet BookPrinter - tikai to attçloðanu konsolç.

	public string Title { get; }
	public string Author { get; }
	public bool IsBorrowed { get; private set; }

	public Book(string title, string author)
	{
		Title = title;
		Author = author;
		IsBorrowed = false;
	}

	public bool Borrow()
	{
		if (IsBorrowed)
			return false;

		IsBorrowed = true;
		return true;
	}

	public bool Return()
	{
		if (!IsBorrowed)
			return false;

		IsBorrowed = false;
		return true;
	}
}
