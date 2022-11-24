namespace KraevedAPI.Models;

/// <summary>
/// Статус для бизнес-объекта
/// </summary>
public class State
{
    public State(Guid id, string title, MetaType metaType)
    {
        this.Id = id;
        this.Title = title;
        this.MetaType = metaType;

    }
    public Guid Id { get; set; }

    /// <summary>
    /// Заголовок
    /// </summary>
    /// <value></value>
    public string Title { get; set; }

    /// <summary>
    /// Идентификатор метатипа
    /// </summary>
    /// <value></value>
    public Guid? MetaTypeId { get; set; }

    /// <summary>
    /// Метатип
    /// </summary>
    /// <value></value>
    public MetaType MetaType { get; set; }
}