# 🔔 Real-time Notification System POC

A clean and scalable proof-of-concept system for real-time user notifications using **ASP.NET Core Web API**, **SignalR**, and **Hangfire**. Built with SOLID principles and ready for enterprise-scale adaptation.

## 🚀 Features

- ✅ Real-time user-specific notifications via SignalR
- 🕒 Background job scheduling using Hangfire
- 🔌 Pluggable architecture for easy extension (e.g., email, push notifications)
- 🧱 Clean separation of concerns (Domain, Application, Infrastructure)
- 🌐 Cross-origin access support (CORS)
- 💡 Ready for integration in legacy or modern systems

---

## 📁 Project Structure

NotificationSystemPOC/
│
├── Notification.API # Main Web API entry point
│ ├── Controllers # API endpoints
│ ├── Program.cs # SignalR + Hangfire setup
│ └── appsettings.json
│
├── Notification.Core # Domain models & interfaces
│
├── Notification.Infrastructure # SignalR hubs, services, EF DbContext
│
├── Notification.Scheduler # Background job scheduler using Hangfire
│
└── Notification.Client # Optional frontend or external trigger


---

## 🧪 Sample Use

### Schedule a Notification Job

```json
POST /api/notifications/schedule
{
  "sender": "admin@example.com",
  "recipients": ["user1", "user2"],
  "content": "📅 This message is scheduled!",
  "type": 2,
  "scheduledAt": "2025-05-10T14:00:00Z"
}
  POST /api/notifications/notify

{
  "sender": "admin@example.com",
  "recipients": ["hady", "user2@example.com"],
  "content": "Hellod team! 🔔",
  "type":2 ,
  "metadata": {
    "priority": "high"
  }
}
/notifications?userId={USER_ID}

🛠️ Technologies
.NET 8
SignalR
Hangfire
SQL Server
Entity Framework Core
CORS
Swagger (OpenAPI)


