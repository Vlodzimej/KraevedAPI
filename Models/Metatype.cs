namespace KraevedAPI.Models;

public class MetaType
{
    public MetaType(Guid Id, string Name, string Title)
    {
        this.Id = Id;
        this.Name = Name;
        this.Title = Title;

    }

    public Guid Id { get; set; }

    /// <summary>
    /// Наименование
    /// </summary>
    /// <value></value>
    public string Name { get; set; }

    /// <summary>
    /// Заголовок
    /// </summary>
    /// <value></value>
    public string Title { get; set; }
}

/// События 95f178b6-35a3-40a9-9af8-61a85ba44c6a