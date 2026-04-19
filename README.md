# MVP-Agenda

## 📌 Sobre o Projeto

API de agendamento desenvolvida em C# com ASP.NET Core.

O objetivo é permitir o gerenciamento de compromissos com regras de negócio bem definidas, garantindo consistência dos dados e evitando conflitos de horários.

## 🚀 Funcionalidades

* Criar agendamentos
* Atualizar agendamentos
* Remover agendamentos
* Listar agendamentos
* Impedir criação de horários no passado
* Impedir colisão entre agendamentos

## 📋 Regras de Negócio

* Um agendamento deve possuir:
  * Título
  * Descrição
  * Data e hora do evento

* O sistema registra automaticamente:
  * Data de criação
  * Data de atualização

* Não é permitido:
  * Criar agendamentos em datas passadas
  * Criar agendamentos com horários conflitantes

## 🛠️ Tecnologias

* C#
* ASP.NET Core Web API
* Entity Framework (em breve)
* SQL Server (em breve)

## ▶️ Como Executar

```bash
dotnet run
```

## 🔗 Endpoints (Planejado)

* GET /horarios → Listar todos
* GET /horarios/{id} → Buscar por id
* POST /horarios → Criar
* PUT /horarios/{id} → Atualizar
* DELETE /horarios/{id} → Remover
## 🧠 Roadmap

* [ ] CRUD básico
* [ ] Validação de regras de negócio
* [ ] Integração com banco de dados
* [ ] Autenticação (JWT)
* [ ] Notificações
* [ ] Integração com frontend
* [ ] Melhorias de performance

## 🎯 Objetivo

Evoluir este projeto para uma solução mais completa de gerenciamento de tempo, podendo futuramente integrar automações e assistentes inteligentes.

## 📄 Licença

Projeto desenvolvido para fins de estudo e portfólio.
