namespace KraevedAPI.Models;

/// <summary>
/// Бизнес-объект
/// </summary>
public class BusinessObject
{
    public BusinessObject(BusinessObject businessObject)
    {
        this.Id = businessObject.Id;
        this.Name = businessObject.Name;
        this.Title = businessObject.Title;
        this.MetaTypeId = businessObject.MetaTypeId;
        this.MetaType = businessObject.MetaType;
        this.StartDate = businessObject.StartDate;
        this.FinishDate = businessObject.FinishDate;
        this.CustomProperties = businessObject.CustomProperties;
        this.UserId = businessObject.UserId;
        this.User = businessObject.User;
        this.State = businessObject.State;
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

    /// <summary>
    /// Идентификатор метатипа
    /// </summary>
    /// <value></value>
    public Guid MetaTypeId { get; set; }

    /// <summary>
    /// Метатип объекта
    /// </summary>
    /// <value></value>
    public virtual MetaType MetaType { get; set; }

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

    /// <summary>
    /// Идентификатор автора
    /// </summary>
    /// <value></value>
    public Guid UserId { get; set; }

    /// <summary>
    /// Автор
    /// </summary>
    /// <value></value>
    public User User { get; set; }

    /// <summary>
    /// Статус
    /// </summary>
    /// <value></value>
    public State State { get; set; }
}