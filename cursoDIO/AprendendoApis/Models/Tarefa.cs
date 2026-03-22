namespace AprendendoApis.Models;

[Table("tarefas")]
public class Tarefa
{
    [Key]
    [DatabaseGenerated(DataBaseGeneratedOption.Identity)]
    public int Id { get; set; } = default!;
    [Required]
    [StringLength (100)]
    public string Titulo { get; set; } = default!;
    [Column(TypeName = "text")]
    public string Descricao { get; set; } = default!;

    
    public bool Concluida { get; set; } = default!;
};

