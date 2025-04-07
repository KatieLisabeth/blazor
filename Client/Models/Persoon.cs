using System;

namespace blazor.Client.Models;

public class Persoon
{
    public int Id { get; set; }
    public required string Voornaam { get; set; }
    public required string Familienaam { get; set; }
}
