namespace KraevedAPI.Models;

/// <summary>
/// Пользователь
/// </summary>
public class User
{
    public User(Guid id, string firstName, string lastName, string username, DateTime startDate, DateTime finishDate, Role role, string email, string status)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Username = username;
        this.StartDate = startDate;
        this.FinishDate = finishDate;
        this.Role = role;
        this.Email = email;
        this.Status = status;

    }

    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Логин
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// Хэш пароля
    /// </summary>
    public byte[] PasswordHash { get; set; }

    /// <summary>
    /// Соль пароля
    /// </summary>
    public byte[] PasswordSalt { get; set; }

    /// <summary>
    /// Дата регистрации
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Дата удаления
    /// </summary>
    public DateTime FinishDate { get; set; }

    /// <summary>
    /// Идентификтор роли
    /// </summary>
    public Guid? RoleId { get; set; }

    /// <summary>
    /// Роль
    /// </summary>
    /// <value></value>
    public Role Role { get; set; }

    /// <summary>
    /// Почта
    /// </summary>
    /// <value></value>
    public string Email { get; set; }

    /// <summary>
    /// Статус
    /// </summary>
    /// <value></value>
    public string Status { get; set; }
}
