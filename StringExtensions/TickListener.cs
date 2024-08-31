using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    internal class TickListener
    {
        public event EventHandler<String> Listener;
        public void ListenForTicks()
        {
            OnProcessCompleted("Heard you.");
        }
        public virtual void OnProcessCompleted(string message) { Listener.Invoke(this, message); }
    }
}
