namespace Gtfs.Domain.Models;

public class Source
{
	public int Id { get; set; }
	public required string Name { get; set; }
	
	public ICollection<Agency> Agencies = new List<Agency>();
}