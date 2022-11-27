namespace KraevedAPI.Models;

/// <summary>
/// Бизнес-объект
/// </summary>
public class BusinessObject
{
    public BusinessObject(Guid id, string title, Guid metaTypeId, string customProperties)
    {
        this.Id = id;
        this.Title = title;
        this.MetaTypeId = metaTypeId;
        this.CustomProperties = customProperties;

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
    public Guid MetaTypeId { get; set; }

    /// <summary>
    /// Метатип объекта
    /// </summary>
    /// <value></value>
    //public virtual MetaType? MetaType { get; set; }

    /// <summary>
    /// Дата создания
    /// </summary>
    /// <value></value>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Дата завершения
    /// </summary>
    /// <value></value>
    public DateTime? FinishDate { get; set; }

    /// <summary>
    /// Дополнительные свойства
    /// </summary>
    /// <value></value>
    public string CustomProperties { get; set; }
}