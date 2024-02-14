using FunnyQuotes.Models;

namespace FunnyQuotes.Pages;

public partial class Quote
{
	public QuoteModel? CurrentQuote { get; set; }
	public int UpVotes { get; set; }
	public int DownVotes { get; set; }

	protected override void OnInitialized()
	{
		CurrentQuote = new QuoteModel
		{
			Quote = "Eat(); Code(); Sleep(); Repeat();",
			Author = "Robert Patruche",
			Anonymous = false
		};
	}

	public void UpVote() => UpVotes++;
	public void DownVote() => DownVotes++;
}