namespace KraevedAPI.Models;

/// <summary>
/// Роли пользователей
/// </summary>
public class Role
{
    public Role(Guid id, string name)
    {
        this.Id = id;
        this.Name = name;
        this.Users = new List<User>();

    }
    public Guid Id { get; set; }

    /// <summary>
    /// Название роли
    /// </summary>
    /// <value></value>
    public string Name { get; set; }

    /// <summary>
    /// Список пользователей
    /// </summary>
    /// <value></value>
    public List<User> Users { get; set; }
}