using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Mediator
    {
        public void Run()
        {
            Imediator mediator = new ConcreteMediator();
            IParticipant participant1 = new ConcreteParticipant1(mediator);
            IParticipant participant2 = new ConcreteParticipant2(mediator);
            mediator.AddParticipant(participant1);
            mediator.AddParticipant(participant2);
            participant1.SendMessage("This is the first participant");
            participant2.SendMessage("This is the second participant");
            Console.ReadLine();
        }
    }

    public interface IParticipant
    {
        void SendMessage(string message);
    }

    public class ConcreteParticipant1 : IParticipant
    {
        protected Imediator mediator;
        public ConcreteParticipant1(Imediator mediator)
        {
            this.mediator = mediator;
        }
        public void SendMessage(string message)
        {
            mediator.BroadcastMessage(message, this);
        }
    }
    public class ConcreteParticipant2 : IParticipant
    {
        protected Imediator mediator;
        public ConcreteParticipant2(Imediator mediator)
        {
            this.mediator = mediator;
        }
        public void SendMessage(string message)
        {
            mediator.BroadcastMessage(message, this);
        }
    }

    public interface Imediator
    {
        void AddParticipant(IParticipant participant);
        void BroadcastMessage(string message, IParticipant sender);
    }

    public class ConcreteMediator : Imediator
    {
        List<IParticipant> participants = new List<IParticipant>();
        public void AddParticipant(IParticipant participant)
        {
            participants.Add(participant);
        }
        public void BroadcastMessage(string message, IParticipant sender)
        {
            // Write code here to broadcast the message to the participants
        }
    }
}
