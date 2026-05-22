# API de Todos

## Tema

Esta API permite gerenciar tarefas (*todos*), com operações de criação, leitura, atualização e exclusão.

## Tecnologias utilizadas

- C#
- ASP.NET Core Web API
- Entity Framework Core
- SQLite

## Como executar

```bash
dotnet run
```
## Endpoints

| Método | Rota | Descrição | Status HTTP esperado |
| --- | --- | --- | --- |
| GET | ``/v1/todos`` | Lista todas as tarefas | 200 OK |
| GET | ``/v1/todos/{id}`` | Busca uma tarefa por ID | 200 OK / 404 Not Found |
| POST | ``/v1/todos`` | Cadastra uma nova tarefa | 201 Created / 400 BadRequest / 409 Conflict / 500 Internal Server Error |
| PUT | ``/v1/todos/{id}`` | Atualiza uma tarefa existente | 200 OK / 400 BadRequest / 404 Not Found / 500 Internal Server Error |
| DELETE | ``/v1/todos/{id}`` | Remove uma tarefa | 204 No Content / 404 Not Found / 500 Internal Server Error |

## Exemplo de Json
 Post
{
  "title": "Estudar C#"
}
// POST
{
  "title": "Estudar C#"
}

// PUT
{
  "id": 1,
  "title": "Estudar C# com Web API",
  "done": true,
  "date": "2026-05-21T23:30:00"
}
Put
