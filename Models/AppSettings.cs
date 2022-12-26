namespace Application.Models;

public class AppSettings
{
    public Api? Api { get; set; }
    public Company? Company { get; set; }
    public MenuSettings MenuSettings { get; set; }

    public OpenGraph OpenGraph { get; set; }
}


public class MenuSettings
{
    public string BackgroundImage { get; set; }
}