using FunnyQuotes.Models;

namespace FunnyQuotes.Services;

public class QuoteService
{
	public static readonly string DEFAULT_QUOTE = string.Empty;
	
	public QuoteService()
	{
		
	}

	public QuoteModel? GetRandomQuote()
	{
		return new QuoteModel { Quote = DEFAULT_QUOTE };
	}
}