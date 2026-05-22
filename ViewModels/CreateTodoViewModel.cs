using System.ComponentModel.DataAnnotations;

namespace MeuTodo.ViewModel.cs
{
    public class CreateTodoViewModel
    {
        [Required]
        public string Title {get; set; }
    }
}