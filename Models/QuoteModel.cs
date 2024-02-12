namespace FunnyQuotes.Models;

public class QuoteModel
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public string? Quote { get; set; }
	public string? Author { get; set; }
	public bool Anonymous { get; set; } = true;
}