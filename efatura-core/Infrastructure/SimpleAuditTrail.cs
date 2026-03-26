using System;
using System.Collections.Generic;
using EFatura.Core.Application;

namespace EFatura.Core.Infrastructure
{
    public sealed class SimpleAuditTrail : IAuditTrail
    {
        private readonly List<string> _events = new List<string>();

        public IReadOnlyList<string> Events => _events;

        public void Write(Guid invoiceId, string action, string details)
        {
            _events.Add(string.Format("{0:u} | {1} | {2} | {3}", DateTime.UtcNow, invoiceId, action, details));
        }
    }
}
