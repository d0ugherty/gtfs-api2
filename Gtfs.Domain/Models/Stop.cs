using System.ComponentModel.DataAnnotations.Schema;

namespace Gtfs.Domain.Models;

public class Stop
{
	public int Id { get; set; }

	public required string StopNumber { get; set; }

	public string? Name { get; set; }

	public string? Description { get; set; }

	public float Latitude { get; set; }

	public float Longitude { get; set; }

	public string? ZoneId { get; set; }

	public string? Url { get; set; }

	public List<StopTime> StopTimes { get; set; }

	[ForeignKey("Source")] 
	public int SourceId { get; set; }

	public required Source Source { get; set; }

	public Stop()
	{
		StopTimes = new List<StopTime>();
	}
}