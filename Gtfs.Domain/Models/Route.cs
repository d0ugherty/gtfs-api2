using System.ComponentModel.DataAnnotations.Schema;

namespace Gtfs.Domain.Models;

public class Route
{
	
	public int Id { get; set; }
	
	public required string RouteNumber { get; set; } = null!;
	
	public string? ShortName { get; set; }
	
	public string? LongName { get; set; }
	
	public string? Description { get; set; }
	
	public int? Type { get; set; }
	
	public string? Color { get; set; }
	
	public string? TextColor { get; set; }
	
	public string? Url { get; set; }

	public List<Trip> Trips { get; set; }

	[ForeignKey("Agency")] 
	public int? AgencyId { get; set; }

	public Agency? Agency { get; set; }

	public Route()
	{
		Trips = new List<Trip>();
	}
}